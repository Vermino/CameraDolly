namespace ACBindingsTest.Internal;


/// <summary>Manages the state of an item examination UI, tracking the object being examined, its Weenie representation, appraisal data, and parent element linkage.</summary>
public unsafe struct ExamineSubUI
{
    // Child Types
    public unsafe struct ExamineSubUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ExamineSubUI*, uint, ACBindingsTest.Internal.ACCWeenieObject*, void> Init; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ExamineSubUI*, ACBindingsTest.Internal.AppraisalProfile*, int, void> SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.ExamineSubUI*, byte, void> Show; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint cur_objid;
    public ACBindingsTest.Internal.ACCWeenieObject* cur_weenobj;
    public ACBindingsTest.Internal.AppraisalProfile cur_prof;
    public ACBindingsTest.Internal.gmExaminationUI* m_pParentElement;

    // Methods

    /// <summary>Initializes the Examination Sub‑UI with a specific object ID and its associated Weenie object.
    /// <code>Offset: 0x004AB530
    /// void __thiscall ExamineSubUI::Init(ExamineSubUI*,unsigned int,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="objid">The unique identifier of the examined object.</param>
    /// <param name="weenObj">Pointer to the ACCWeenieObject representing the examined item or entity.</param>
    public void Init(uint objid, ACBindingsTest.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.ExamineSubUI, uint, ACBindingsTest.Internal.ACCWeenieObject*, void>)0x004AB530)(ref this, objid, weenObj);
}

