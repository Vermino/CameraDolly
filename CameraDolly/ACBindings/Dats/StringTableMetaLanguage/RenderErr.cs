namespace ACBindingsTest.Internal.StringTableMetaLanguage;


/// <summary>
/// Records an error that occurs during rendering of string table meta language, providing the position where it happened, the specific error code, and a descriptive message.
/// </summary>
public unsafe struct RenderErr
{
    // Members
    public int pos;
    public ACBindingsTest.Internal.StringTableMetaLanguage.RenderErrorCode code;
    public ACBindingsTest.Internal.PStringBase__sbyte msg;

    // Methods
}

