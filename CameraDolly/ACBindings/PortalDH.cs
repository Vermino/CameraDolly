namespace ACBindingsTest.Internal;


/// <summary>Encapsulates Diffie‑Hellman parameters used for secure key agreement, storing the shared base and prime values required in cryptographic exchanges.</summary>
public unsafe struct PortalDH
{
    // Members
    public ACBindingsTest.Internal.AC1Legacy.vlong shared_base_;
    public ACBindingsTest.Internal.AC1Legacy.vlong shared_prime_;

    // Methods

    /// <summary>Initializes PortalDH with the supplied base and prime values.
    /// <code>Offset: 0x005B1300
    /// int __thiscall PortalDH::Init(PortalDH*,AC1Legacy::vlong*,AC1Legacy::vlong*)</code>
    /// </summary>
    /// <param name="shared_base">Pointer to AC1Legacy::vlong containing the shared base value.</param>
    /// <param name="shared_prime">Pointer to AC1Legacy::vlong containing the shared prime value.</param>
    /// <returns>Always returns 1 to indicate successful initialization.</returns>
    public int Init(ACBindingsTest.Internal.AC1Legacy.vlong* shared_base, ACBindingsTest.Internal.AC1Legacy.vlong* shared_prime) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.PortalDH, ACBindingsTest.Internal.AC1Legacy.vlong*, ACBindingsTest.Internal.AC1Legacy.vlong*, int>)0x005B1300)(ref this, shared_base, shared_prime);
}

