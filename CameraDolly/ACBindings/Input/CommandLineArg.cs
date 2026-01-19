namespace ACBindingsTest.Internal;


/// <summary>Represents a command‑line argument definition used to parse program options, storing metadata such as short and long identifiers, description, target variable, default value, and custom user data.</summary>
public unsafe struct CommandLineArg : System.IDisposable
{
    // Members
    public int ArgType;
    public sbyte ShortVersion;
    public ACBindingsTest.Internal.PStringBase__sbyte LongVersion;
    public ACBindingsTest.Internal.PStringBase__sbyte Description;
    public System.IntPtr VariableToModify;
    public uint ValueToStore;
    public uint UserData;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Decrements reference counts for the Description and LongVersion strings, freeing their buffers when no longer referenced.
    /// <code>Offset: 0x00402280
    /// void __thiscall CommandLineArg::~CommandLineArg(CommandLineArg*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindingsTest.Internal.CommandLineArg, void>)0x00402280)(ref this);
}

