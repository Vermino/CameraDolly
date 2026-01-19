namespace ACBindingsTest.Internal;


/// <summary>Specialized examination UI that displays detailed information about a creature, extending basic examination functionality with a dedicated display name element.</summary>
/// <remarks>Handles presentation of appraisal data and toggles visibility of the examine interface within the game’s user interface system.</remarks>
public unsafe struct CreatureExamineUI
{
    // Base Classes
    public ACBindingsTest.Internal.BasicCreatureExamineUI BaseClass_BasicCreatureExamineUI; // ACBindingsTest.Internal.BasicCreatureExamineUI

    // Child Types
    public unsafe struct CreatureExamineUI_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CreatureExamineUI*, uint, ACBindingsTest.Internal.ACCWeenieObject*, void> Init; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CreatureExamineUI*, ACBindingsTest.Internal.AppraisalProfile*, int, void> SetAppraiseInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindingsTest.Internal.CreatureExamineUI*, byte, void> Show; // function pointer

        // Methods
    }

    // Members
    public ACBindingsTest.Internal.UIElement_Text* m_creatureDisplayName;

    // Methods

    /// <summary>Shows or hides the creature examination interface by updating its primary field and information panel visibility.
    /// <code>Offset: 0x004AB920
    /// void __thiscall CreatureExamineUI::Show(CreatureExamineUI*,bool)</code>
    /// </summary>
    /// <param name="shown">True to display the UI, false to hide it.</param>
    public void Show(byte shown) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CreatureExamineUI, byte, void>)0x004AB920)(ref this, shown);

    /// <summary>Updates the creature examination UI with appraisal data, including name, rating, damage, resistances, and additional combat statistics, then delegates to the base class implementation.
    /// <code>Offset: 0x004B4690
    /// void __thiscall CreatureExamineUI::SetAppraiseInfo(CreatureExamineUI*,const AppraisalProfile*,int)</code>
    /// </summary>
    /// <param name="prof">The appraisal profile containing the creature's stats and attributes.</param>
    /// <param name="is_new">Flag indicating whether this is a fresh appraisal session (used by the base UI logic).</param>
    public void SetAppraiseInfo(ACBindingsTest.Internal.AppraisalProfile* prof, int is_new) => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CreatureExamineUI, ACBindingsTest.Internal.AppraisalProfile*, int, void>)0x004B4690)(ref this, prof, is_new);
}

