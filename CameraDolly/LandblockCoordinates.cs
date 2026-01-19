using System;

namespace CameraDolly
{
    /// <summary>
    /// Helper class for Asheron's Call landblock coordinate system conversions.
    /// 
    /// Coordinate System:
    /// - Landblock: 255x255 grid, indices 0x00-0xFE (XX, YY in cell ID 0xXXYY0000)
    /// - Local Units (LU): Each landblock is 192x192 LU, range [0, 192)
    /// - Compass Units (CU): Global coordinates, range approximately [-102, 102]
    /// - Cell ID format: 0xXXYYTTLL where XX=landblock X, YY=landblock Y, TT=type, LL=landcell
    /// - Outdoor cells have (cellId & 0xFFFF) < 0x100
    /// </summary>
    public static class LandblockCoordinates
    {
        /// <summary>Local units per landblock dimension.</summary>
        public const float LB_SIZE = 192.0f;

        /// <summary>Compass coordinate range (approximately -102 to +102).</summary>
        public const float COMPASS_RANGE = 204.0f;

        /// <summary>Number of landblocks per dimension (0-254).</summary>
        public const int LB_COUNT = 255;

        /// <summary>
        /// Checks if a cell ID represents an outdoor (landscape) location.
        /// Indoor cells have (cellId & 0xFFFF) >= 0x100.
        /// </summary>
        public static bool IsOutside(uint cellId)
        {
            return (cellId & 0xFFFF) < 0x100;
        }

        /// <summary>
        /// Normalizes a Position's local coordinates to stay within [0, 192) and updates
        /// the landblock portion of objcell_id accordingly. Only applies to outdoor positions.
        /// </summary>
        public static unsafe void NormalizePosition(ref ACBindingsTest.Internal.Position pos)
        {
            // Only normalize outdoor positions
            if (!IsOutside(pos.objcell_id))
                return;

            ref float localX = ref pos.frame.m_fOrigin.BaseClass_Vector3.x;
            ref float localY = ref pos.frame.m_fOrigin.BaseClass_Vector3.y;

            // Extract current landblock indices from cell ID (0xXXYY0000 format)
            int lbX = (int)((pos.objcell_id >> 24) & 0xFF);
            int lbY = (int)((pos.objcell_id >> 16) & 0xFF);

            // Normalize X coordinate
            while (localX < 0)
            {
                localX += LB_SIZE;
                lbX--;
            }
            while (localX >= LB_SIZE)
            {
                localX -= LB_SIZE;
                lbX++;
            }

            // Normalize Y coordinate
            while (localY < 0)
            {
                localY += LB_SIZE;
                lbY--;
            }
            while (localY >= LB_SIZE)
            {
                localY -= LB_SIZE;
                lbY++;
            }

            // Clamp landblock indices to valid range [0, 254]
            lbX = Math.Max(0, Math.Min(254, lbX));
            lbY = Math.Max(0, Math.Min(254, lbY));

            // Calculate new landcell index within landblock (1-64)
            // Each landblock has 8x8 = 64 landcells, each 24 LU wide
            int cellX = (int)(localX / 24.0f);
            int cellY = (int)(localY / 24.0f);
            cellX = Math.Max(0, Math.Min(7, cellX));
            cellY = Math.Max(0, Math.Min(7, cellY));
            int landcell = (cellX << 3) | cellY;

            // Reconstruct cell ID: 0xXXYY00LL (outdoor format, TT=00, LL=landcell+1)
            pos.objcell_id = (uint)((lbX << 24) | (lbY << 16) | (landcell + 1));
        }
        /// <summary>
        /// Converts landblock local Y coordinate to compass NS coordinate.
        /// </summary>
        public static float LandblockToNS(uint landcell, float yOffset)
        {
            uint l = (uint)((landcell & 0x00FF0000) / 0x2000);
            float ns = ((yOffset / 24.0f) + l - 1019.5f) / 10.0f;
            return ns;
        }
        /// <summary>
        /// Converts landblock local X coordinate to compass EW coordinate.
        /// </summary>
        public static float LandblockToEW(uint landcell, float xOffset)
        {
            uint l = (uint)((landcell & 0xFF000000) / 0x200000);
            float ew = ((xOffset / 24.0f) + l - 1019.5f) / 10.0f;
            return ew;
        }
        /// <summary>
        /// Converts compass coordinates to a cell ID (landblock + landcell).
        /// </summary>
        public static uint GetLandblockFromCoordinates(float EW, float NS)
        {
            NS -= 0.5f;
            EW -= 0.5f;
            NS *= 10.0f;
            EW *= 10.0f;

            uint basex = (uint)(EW + 0x400);
            uint basey = (uint)(NS + 0x400);

            byte blockx = (byte)(basex >> 3);
            byte blocky = (byte)(basey >> 3);
            byte cellx = (byte)(basex & 7);
            byte celly = (byte)(basey & 7);

            int block = (blockx << 8) | blocky;
            int cell = (cellx << 3) | celly;

            int dwCell = (block << 16) | (cell + 1);
            return (uint)dwCell;
        }
        /// <summary>
        /// Converts compass NS coordinate to landblock local Y offset.
        /// </summary>
        public static float NSToLandblock(uint landcell, float ns)
        {
            uint l = (uint)((landcell & 0x00FF0000) / 0x2000);
            float yOffset = ((ns * 10.0f) - l + 1019.5f) * 24.0f;
            return yOffset;
        }
        /// <summary>
        /// Converts compass EW coordinate to landblock local X offset.
        /// </summary>
        public static float EWToLandblock(uint landcell, float ew)
        {
            uint l = (uint)((landcell & 0xFF000000) / 0x200000);
            float xOffset = ((ew * 10.0f) - l + 1019.5f) * 24.0f;
            return xOffset;
        }
    }
}
