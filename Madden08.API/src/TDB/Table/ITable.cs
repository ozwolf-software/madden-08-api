namespace Madden08.API.TDB.Table;

internal interface ITable<T>
{
    string Name { get; }
    T Load(TableRecord record);
    void Save(T item, TableRecord record);
}