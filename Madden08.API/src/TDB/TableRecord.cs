using Madden08.API.Util;

namespace Madden08.API.TDB;

internal class TableRecord(int handle, TableProperties table, int record)
{
    public int Record => record;

    public int GetInt(string fieldName) =>
        TDBAccess.TDBFieldGetValueAsInteger(handle, table.Name, fieldName, record);

    public string GetString(string fieldName)
    {
        FieldProperties field = GetField(fieldName);
        string buffer = new(' ', field.Size);
        if (TDBAccess.TDBFieldGetValueAsString(handle, table.Name, fieldName, record, ref buffer))
            return buffer;

        throw new InvalidOperationException($"Error retrieving string field [ {fieldName} ] from [ {table.Name} ]");
    }

    public bool SetInt(string fieldName, int value) =>
        TDBAccess.TDBFieldSetValueAsInteger(handle, table.Name, fieldName, record, value);

    public bool SetString(string fieldName, string value) =>
        TDBAccess.TDBFieldSetValueAsString(handle, table.Name, fieldName, record, value);

    private FieldProperties GetField(string fieldName)
    {
        string tableName = table.Name;
        FieldProperties properties = new();

        for (int i = 0; i < table.FieldCount; i++)
        {
            if (TDBAccess.TDBFieldGetProperties(handle, tableName, i, ref properties))
            {
                if (properties.Name.EqualsIgnoreCase(fieldName))
                    return properties;
            }
        }

        throw new InvalidOperationException($"Unknown field [ {fieldName} ] on table [ {table.Name} ]");
    }
}