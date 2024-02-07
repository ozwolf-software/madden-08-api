using Madden08.API.Domain;

namespace Madden08.API.TDB.Table;

internal class DraftPickTable: ITable<DraftPick>
{
    private const string TABLE = "DRPK";
    private const string OVERALL = "DPNM";
    private const string ORIGINALOWNERID = "DPOD";
    private const string OWNERID = "DPID";
    public string Name => TABLE;

    public DraftPick Load(TableRecord record) => new(
        Record : record.Record,
        PickNumber: record.GetInt(OVERALL),
        OwnerId : record.GetInt(OWNERID),
        OriginalOwnerId : record.GetInt(ORIGINALOWNERID)
    );

    public void Save(DraftPick item, TableRecord record)
    {
        record.SetInt(OWNERID, item.OwnerId);
    }
}