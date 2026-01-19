namespace ACBindingsTest.Internal;


/// <summary>Maintains references to UI listeners involved in message removal, including a single listener and an array of listeners for batch cleanup operations.</summary>
public unsafe struct UIMessageRemovalData
{
    // Members
    public ACBindingsTest.Internal.UIListener* pListener;
    public System.IntPtr pListenerArray;

    // Methods
}

