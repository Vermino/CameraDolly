namespace ACBindingsTest.Internal;


/// <summary>Character examination UI component extending BasicCreatureExamineUI, displaying heritage, profession, player killer status, and allegiance name within the parent examination view.</summary>
public unsafe struct CharExamineUI
{
    // Base Classes
    public ACBindingsTest.Internal.BasicCreatureExamineUI BaseClass_BasicCreatureExamineUI; // ACBindingsTest.Internal.BasicCreatureExamineUI

    // Child Types
    public unsafe struct CharExamineUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CharExamineUI*, uint, ACBindingsTest.Internal.ACCWeenieObject*, void> Init; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CharExamineUI*, ACBindingsTest.Internal.AppraisalProfile*, int, void> SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CharExamineUI*, byte, void> Show; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.UIElement_Text* m_displayText_Heritage;
    public ACBindingsTest.Internal.UIElement_Text* m_displayText_Profession;
    public ACBindingsTest.Internal.UIElement_Text* m_displayText_PlayerKiller;
    public ACBindingsTest.Internal.UIElement_Text* m_displayText_AllegianceName;

    // Generated Constructor
    public CharExamineUI(ACBindingsTest.Internal.gmExaminationUI* parentElement) {
        _ConstructorInternal(parentElement);
    }

    // Methods

    /// <summary>Activates or deactivates the primary examination panel and its character information sub-panel based on the supplied flag.
    /// <code>Offset: 0x004AB950
    /// void __thiscall CharExamineUI::Show(CharExamineUI*,bool)</code>
    /// </summary>
    /// <param name="shown">True to display the panels; false to hide them.</param>
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CharExamineUI, byte, void>)0x004AB950)(ref this, shown);

    /// <summary>Constructs a character examination UI component, initializing inherited fields and locating text elements that display heritage, profession, player killer status, and allegiance name within the parent UI.
    /// <code>Offset: 0x004AD740
    /// void __thiscall CharExamineUI::CharExamineUI(CharExamineUI*,gmExaminationUI*)</code>
    /// </summary>
    /// <param name="parentElement">The parent examination UI providing context for the character UI.</param>
    public void _ConstructorInternal(ACBindingsTest.Internal.gmExaminationUI* parentElement) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CharExamineUI, ACBindingsTest.Internal.gmExaminationUI*, void>)0x004AD740)(ref this, parentElement);

    /// <summary>Populates the character examination UI with data from the supplied appraisal profile, updating fields such as heritage, profession, titles, allegiance, armor stats, damage and resistance ratings, and other miscellaneous information.
    /// <code>Offset: 0x004B4EF0
    /// void __thiscall CharExamineUI::SetAppraiseInfo(CharExamineUI*,const AppraisalProfile*,int)</code>
    /// </summary>
    /// <param name="prof">The appraisal profile containing character data to display.</param>
    /// <param name="is_new">Flag indicating whether the appraisal is newly created or refreshed, controlling certain UI updates.</param>
    public void SetAppraiseInfo(ACBindingsTest.Internal.AppraisalProfile* prof, int is_new) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CharExamineUI, ACBindingsTest.Internal.AppraisalProfile*, int, void>)0x004B4EF0)(ref this, prof, is_new);
}

