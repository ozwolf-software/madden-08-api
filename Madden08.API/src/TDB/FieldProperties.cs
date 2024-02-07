using System.Runtime.InteropServices;

namespace Madden08.API.TDB;

/// <summary>
/// Made public for use by the TDB access library.
/// 
/// <strong>DO NOT USE</strong>
/// </summary>
[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public struct FieldProperties
{
    /// <summary/>
    public string Name;

    /// <summary/>
    public int Size;

    /// <summary/>
    public FieldType FieldType;

    /// <summary/>
    public FieldProperties()
    {
        this.Name = "    ";
    }
}