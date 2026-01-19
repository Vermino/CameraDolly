namespace ACBindingsTest.Internal;


/// <summary>Encapsulates bookkeeping information for a migration request, including region range, source/destination servers, sequence identifier and flag flags.</summary>
/// <remarks>Used in inter‑server migration to track pending requests within a packed data stream.</remarks>
public unsafe struct LBMigrationReqBookkeep
{
    // Base Classes
    public ACBindingsTest.Internal.PackableNIListElt___LBMigrationReqBookkeep BaseClass_PackableNIListElt; // ACBindingsTest.Internal.PackableNIListElt___LBMigrationReqBookkeep

    // Members
    public ACBindingsTest.Internal.LBRange region;
    public uint destSrv;
    public uint requestingSrv;
    public int seq;
    public int flags_;

    // Methods
}

