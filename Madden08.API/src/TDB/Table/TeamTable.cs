using Madden08.API.Domain;

namespace Madden08.API.TDB.Table;

internal class TeamTable : ITable<Team>
{
    private const string TABLE = "TEAM";
    private const string ID = "TGID";
    private const string TYPE = "TTYP";
    private const string NAME = "TLNA";
    private const string NICKNAME = "TDNA";
    private const string SHORTNAME = "TSNA";
    private const string OTHERNICK = "TMNC";
    private const string CITY = "CYID";
    private const string STADIUM = "SGID";
    private const string DIVISION = "DGID";
    private const string CAPPENCURRENT = "TCP0";
    private const string CAPPENNEXT = "TCP1";
    private const string SALARY = "TMSA";

    private const int MONEY_FACTOR = 10000;

    public string Name => TABLE;

    public Team Load(TableRecord record) => new(
        Record: record.Record,
        ID: record.GetInt(ID),
        Type: (TeamType) record.GetInt(TYPE),
        Name: record.GetString(NAME),
        NickName: record.GetString(NICKNAME),
        ShortName: record.GetString(SHORTNAME),
        OtherName: record.GetString(OTHERNICK),
        CityId: record.GetInt(CITY),
        StadiumId: record.GetInt(STADIUM),
        Division: (Division) record.GetInt(DIVISION),
        SalaryCap: record.GetInt(SALARY) * MONEY_FACTOR,
        CurrentCapPenalty: record.GetInt(CAPPENCURRENT) * MONEY_FACTOR,
        NextYearCapPenalty: record.GetInt(CAPPENNEXT) * MONEY_FACTOR
    );

    public void Save(Team item, TableRecord record)
    {
        record.SetString(NAME, item.Name);
        record.SetString(NICKNAME, item.NickName);
        record.SetString(SHORTNAME, item.ShortName);
        record.SetString(OTHERNICK, item.OtherName);
        record.SetInt(CITY, item.CityId);
        record.SetInt(SALARY, item.SalaryCap / MONEY_FACTOR);
        record.SetInt(CAPPENCURRENT, item.CurrentCapPenalty / MONEY_FACTOR);
        record.SetInt(CAPPENNEXT, item.NextYearCapPenalty / MONEY_FACTOR);
    }
}