namespace ACBindingsTest.Internal;


/// <summary>Represents the state and presentation of a skill’s quality, storing its current and saved values along with related UI components for progression and level display.</summary>
public unsafe struct SkillQualityBlob
{
    // Members
    public uint m_eQuality;
    public ACBindingsTest.Internal.Skill m_skillSavedValue;
    public ACBindingsTest.Internal.Skill m_skillCurValue;
    public ACBindingsTest.Internal.UIElement_Menu* m_pAdvancementMenu;
    public ACBindingsTest.Internal.UIElement_Text* m_pCurInitLevelText;

    // Methods
}

