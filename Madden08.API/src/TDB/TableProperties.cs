using System.Runtime.InteropServices;

namespace Madden08.API.TDB;

/// <summary>
/// Made public for use by the TDB access library.
/// 
/// <strong>DO NOT USE</strong>
/// </summary>
[StructLayout(LayoutKind.Sequential, CharSet= CharSet.Unicode)]
public struct TableProperties
{
    /// <summary/>
    public string Name;

    /// <summary/>
    public int FieldCount;

    /// <summary/>
    public int Capacity;

    /// <summary/>
    public int RecordCount;

    /// <summary/>
    public int DeletedCount;

    /// <summary/>
    public int NextDeletedRecord;

    /// <summary/>
    public bool Flag0;

    /// <summary/>
    public bool Flag1;

    /// <summary/>
    public bool Flag2;

    /// <summary/>
    public bool Flag3;

    /// <summary/>
    public bool NonAllocated;

    /// <summary/>
    public bool HasVarchar;

    /// <summary/>
    public bool HasCompressedVarchar;

    /// <summary/>
    public TableProperties()
    {
        this.Name = "    ";
    }
}