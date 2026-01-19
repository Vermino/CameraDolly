namespace ACBindingsTest.Internal;


/// <summary>Encapsulates the quality state of a body part, maintaining its current and saved values while linking to UI controls that present damage, variance, and armor statistics.</summary>
public unsafe struct BodyPartQualityBlob
{
    // Members
    public uint m_eQuality;
    public ACBindingsTest.Internal.BodyPart m_partSavedValue;
    public ACBindingsTest.Internal.BodyPart m_partCurValue;
    public ACBindingsTest.Internal.UIElement_Menu* m_pDamageTypeMenu;
    public ACBindingsTest.Internal.UIElement_Text* m_pCurDamage;
    public ACBindingsTest.Internal.UIElement_Text* m_pCurDamageVariance;
    public ACBindingsTest.Internal.UIElement_Text* m_pSlashArmorValue;
    public ACBindingsTest.Internal.UIElement_Text* m_pPierceArmorValue;
    public ACBindingsTest.Internal.UIElement_Text* m_pBludgeonArmorValue;
    public ACBindingsTest.Internal.UIElement_Text* m_pColdArmorValue;
    public ACBindingsTest.Internal.UIElement_Text* m_pFireArmorValue;
    public ACBindingsTest.Internal.UIElement_Text* m_pAcidArmorValue;
    public ACBindingsTest.Internal.UIElement_Text* m_pElectricArmorValue;

    // Methods
}

