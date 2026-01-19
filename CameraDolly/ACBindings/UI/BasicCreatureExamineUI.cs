namespace ACBindingsTest.Internal;


/// <summary>Handles creature examination UI, displaying level, statistics, and a 3‑D model within the game.</summary>
/// <summary>Manages subpanels, extra info list, and quality tokens associated with the examined creature.</summary>
public unsafe struct BasicCreatureExamineUI : System.IDisposable
{
    // Base Classes
    public ACBindingsTest.Internal.ExamineSubUI BaseClass_ExamineSubUI; // ACBindingsTest.Internal.ExamineSubUI

    // Statics
    public static ACBindingsTest.Internal.SmartArray___InfoRegion_ptr* m_rgTokens = (ACBindingsTest.Internal.SmartArray___InfoRegion_ptr*)0x0084011C;

    // Child Types
    public unsafe struct BasicCreatureExamineUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BasicCreatureExamineUI*, uint, ACBindingsTest.Internal.ACCWeenieObject*, void> Init; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BasicCreatureExamineUI*, ACBindingsTest.Internal.AppraisalProfile*, int, void> SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.BasicCreatureExamineUI*, byte, void> Show; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.UIElement* m_basicCreatureExamineBaseField;
    public ACBindingsTest.Internal.UIElement* m_creatureInfoSubPanel;
    public ACBindingsTest.Internal.UIElement* m_characterInfoSubPanel;
    public ACBindingsTest.Internal.UIElement_Text* m_levelValueText;
    public ACBindingsTest.Internal.UIElement_Viewport* m_pPaperDoll;
    public ACBindingsTest.Internal.CPhysicsObj* m_p3DObj;
    public ACBindingsTest.Internal.UIElement_ListBox* m_extraInfoList;

    // Generated Constructor
    public BasicCreatureExamineUI(ACBindingsTest.Internal.gmExaminationUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes the creature examination UI with specified object ID and weenie object, configuring lighting, loading a physics representation, computing its bounding box, and positioning the viewport camera accordingly.
    /// <code>Offset: 0x004ABD40
    /// void __thiscall BasicCreatureExamineUI::Init(BasicCreatureExamineUI*,unsigned int,ACCWeenieObject*)</code>
    /// </summary>
    /// <param name="objid">Identifier of the creature to examine.</param>
    /// <param name="weenObj">Pointer to the weenie object representing the creature.</param>
    public void Init(uint objid, ACBindingsTest.Internal.ACCWeenieObject* weenObj) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.BasicCreatureExamineUI, uint, ACBindingsTest.Internal.ACCWeenieObject*, void>)0x004ABD40)(ref this, objid, weenObj);

    /// <summary>Adds a line of miscellaneous information to the creature examination UI by creating a new item in the extra info list box and populating its two text fields with supplied strings using the specified font.
    /// <code>Offset: 0x004ABF30
    /// void __thiscall BasicCreatureExamineUI::AddLineToMiscInfo(_DWORD*,int*,int*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to the first string to display in the first text field.</param>
    /// <param name="a3">Pointer to the second string to display in the second text field.</param>
    /// <param name="a4">Font identifier used when setting the text of both fields.</param>
    public void AddLineToMiscInfo(int* a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.BasicCreatureExamineUI, int*, int*, int, void>)0x004ABF30)(ref this, a2, a3, a4);

    /// <summary>Initializes a BasicCreatureExamineUI instance, linking it to its parent gmExaminationUI and locating child UI components such as level text, info panels, paper doll viewport, and extra info list. If the static token array is empty, populates it with attribute token regions for display.
    /// <code>Offset: 0x004AD0B0
    /// void __thiscall BasicCreatureExamineUI::BasicCreatureExamineUI(BasicCreatureExamineUI*,gmExaminationUI*)</code>
    /// </summary>
    /// <param name="parentElement">Reference to the owning gmExaminationUI that contains this sub‑UI.</param>
    public void _ConstructorInternal(ACBindingsTest.Internal.gmExaminationUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.BasicCreatureExamineUI, ACBindingsTest.Internal.gmExaminationUI*, void>)0x004AD0B0)(ref this, parentElement);

    /// <summary>Destroys a BasicCreatureExamineUI instance, flushing its extra info list, clearing token data, removing associated 3D objects and paper doll view, and resetting the base ExamineSubUI state.
    /// <code>Offset: 0x004AD660
    /// void __thiscall BasicCreatureExamineUI::~BasicCreatureExamineUI(BasicCreatureExamineUI*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.BasicCreatureExamineUI, void>)0x004AD660)(ref this);

    /// <summary>Sets the creature's level display text within the examination interface, converting the numeric value to a string and handling invalid or unknown levels by showing "???".
    /// <code>Offset: 0x004B4510
    /// void __thiscall BasicCreatureExamineUI::SetLevelValueText(BasicCreatureExamineUI*,int)</code>
    /// </summary>
    /// <param name="level">The numerical level of the creature to display.</param>
    public void SetLevelValueText(int level) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.BasicCreatureExamineUI, int, void>)0x004B4510)(ref this, level);

    /// <summary>Updates the creature examination UI with data from an AppraisalProfile, displaying level information and clearing previous quality tokens before storing the profile internally.
    /// <code>Offset: 0x004B4610
    /// void __thiscall BasicCreatureExamineUI::SetAppraiseInfo(BasicCreatureExamineUI*,const AppraisalProfile*,int)</code>
    /// </summary>
    /// <param name="prof">The appraisal profile containing creature details to display.</param>
    /// <param name="is_new">Flag indicating whether this is a new appraisal; currently unused but retained for API compatibility.</param>
    public void SetAppraiseInfo(ACBindingsTest.Internal.AppraisalProfile* prof, int is_new) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.BasicCreatureExamineUI, ACBindingsTest.Internal.AppraisalProfile*, int, void>)0x004B4610)(ref this, prof, is_new);
}

