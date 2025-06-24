using Madden08.API.Domain;
using Madden08.API.Domain.Coach;
using Madden08.API.TDB.Table;

namespace Madden08.API.TDB;

internal static class Tables
{
    internal static readonly ITable<City> Cities = new CityTable();
    internal static readonly ITable<Team> Teams = new TeamTable();
    internal static readonly ITable<DraftPick> DraftPicks = new DraftPickTable();
    internal static readonly ITable<Stadium> Stadiums = new StadiumTable();
    internal static readonly ITable<Player> Players = new PlayerTable();
    internal static readonly ITable<Coach> Coaches = new CoachTable();
}