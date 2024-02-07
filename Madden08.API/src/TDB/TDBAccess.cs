using System.Runtime.InteropServices;

namespace Madden08.API.TDB;

internal class TDBAccess
{
    [DllImport("tdbaccess.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern int TDBOpen(string fileName);
    
    [DllImport("tdbaccess.dll", SetLastError = true)]
    public static extern bool TDBClose(int handle);
    
    [DllImport("tdbaccess.dll", SetLastError = true)]
    public static extern bool TDBDatabaseCompact(int handle);
    
    [DllImport("tdbaccess.dll", SetLastError = true)]
    public static extern bool TDBSave(int handle);
    
    [DllImport("tdbaccess.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern bool TDBTableGetProperties(int handle, int tableIndex, ref TableProperties properties);
    
    [DllImport("tdbaccess.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool TDBFieldGetProperties(int handle, string tableName, int fieldIndex,
        ref FieldProperties properties);
    
    [DllImport("tdbaccess.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern int TDBFieldGetValueAsInteger(int handle, string tableName, string fieldName, int record);
    
    [DllImport("tdbaccess.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool TDBFieldGetValueAsString(int handle, string tableName, string fieldName, int record,
        ref string buffer);
    
    [DllImport("tdbaccess.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool TDBFieldSetValueAsInteger(int handle, string tableName, string fieldName, int record,
        int newValue);
    
    [DllImport("tdbaccess.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool TDBFieldSetValueAsString(int handle, string tableName, string fieldName, int record,
        string newValue);
    
    [DllImport("tdbaccess.dll", SetLastError = true)]
    public static extern int TDBDatabaseGetTableCount(int handle);
}