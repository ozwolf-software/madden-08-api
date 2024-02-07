using Madden08.API.Domain;

namespace Madden08.API.TDB.Table;

internal class CityTable: ITable<City>
{
    private const string TABLE = "CITY";
    private const string ID = "CYID";
    private const string NAME = "CYNM";
    private const string POPULATION = "CPOP";
    private const string STATE = "CYST";
    private const string REGION = "CREG";
    private const string OWNERMODE = "CYOM";

    public string Name => TABLE;

    public City Load(TableRecord record) => new(
        Record : record.Record,
        ID : record.GetInt(ID),
        Name : record.GetString(NAME),
        Population : record.GetInt(POPULATION),
        State : record.GetString(STATE),
        Region : (CityRegion) record.GetInt(REGION),
        OwnerMode : record.GetInt(OWNERMODE) == 1
    );

    public void Save(City item, TableRecord record)
    {
        record.SetString(NAME, item.Name);
        record.SetInt(REGION, (int) item.Region);
        record.SetInt(POPULATION, item.Population);
        record.SetInt(OWNERMODE, item.OwnerMode ? 1 : 0);
    }
}