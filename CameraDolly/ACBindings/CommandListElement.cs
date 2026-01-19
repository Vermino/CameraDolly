namespace ACBindingsTest.Internal;


/// <summary>Represents a node in a doubly linked list of executable commands, holding the command identifier, speed parameter, and hold/run flag used during command processing.</summary>
public unsafe struct CommandListElement
{
    // Members
    public ACBindingsTest.Internal.CommandListElement* next;
    public ACBindingsTest.Internal.CommandListElement* prev;
    public uint command;
    public float speed;
    public int hold_run;

    // Methods
}

