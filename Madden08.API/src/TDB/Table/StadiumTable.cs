using Madden08.API.Domain;

namespace Madden08.API.TDB.Table;

internal record StadiumTable : ITable<Stadium>
{
    private const string TABLE = "STAD";
    private const string ID = "SGID";
    private const string NAME = "SNAM";
    private const string TYPE = "STYP";
    private const string TOTALCAPACITY = "SCAP";
    private const string CITY = "CYID";
    private const string AGE = "SYRO";
    private const string PRACTICE = "STPR";
    private const string RATING = "SRAT";
    private const string CLUBSEAT = "SCCS";
    private const string LUXURYBOX = "SCLB";
    private const string LOWERLEVEL = "SCLL";
    private const string MIDLEVEL = "SCML";
    private const string UPPERLEVEL = "SCUL";
    private const string UPPERENDZONE = "SCUE";
    private const string NENDZONE1 = "SP00";
    private const string NENDZONE2 = "SP01";
    private const string NENDZONE3 = "SP02";
    private const string NWCORNER = "SP03";
    private const string NECORNER = "SP04";
    private const string SENDZONE1 = "SP05";
    private const string SENDZONE2 = "SP06";
    private const string SENDZONE3 = "SP07";
    private const string SWCORNER = "SP08";
    private const string SECORNER = "SP09";
    private const string ESIDELINE1 = "SP10";
    private const string ESIDELINE2 = "SP11";
    private const string ESIDELINE3 = "SP12";
    private const string WSIDELINE1 = "SP13";
    private const string WSIDELINE2 = "SP14";
    private const string WSIDELINE3 = "SP15";
    private const string GRASSTYPE = "SP21";
    private const string LIGHTTYPE = "SP16";
    private const string ROOFTYPE = "SP17";

    public string Name => TABLE;

    public Stadium Load(TableRecord record) => new(
        Record: record.Record,
        ID: record.GetInt(ID),
        CityId: record.GetInt(CITY),
        Name: record.GetString(NAME),
        Age: record.GetInt(AGE),
        Rating: record.GetInt(RATING),
        PracticeField: (PracticeFieldType)record.GetInt(PRACTICE),
        Type: (StadiumType)record.GetInt(TYPE),
        Surface: (GrassType)record.GetInt(GRASSTYPE),
        Capacity: new Capacity(
            UpperEndZone: record.GetInt(UPPERENDZONE),
            LowerLevel: record.GetInt(LOWERLEVEL),
            LuxuryBoxes: record.GetInt(LUXURYBOX),
            MidLevel: record.GetInt(MIDLEVEL),
            UpperLevel: record.GetInt(UPPERLEVEL),
            ClubSeats: record.GetInt(CLUBSEAT)
        ),
        Configuration: new StadiumConfiguration(
            EastSideline: new StadiumConfiguration.Sideline(
                Tier1: (StadiumSection.SidelineTier1)record.GetInt(ESIDELINE1),
                Tier2: (StadiumSection.SidelineTier2)record.GetInt(ESIDELINE3),
                Tier3: (StadiumSection.SidelineTier3)record.GetInt(ESIDELINE2)
            ),
            WestSideline: new StadiumConfiguration.Sideline(
                Tier1: (StadiumSection.SidelineTier1)record.GetInt(WSIDELINE1),
                Tier2: (StadiumSection.SidelineTier2)record.GetInt(WSIDELINE3),
                Tier3: (StadiumSection.SidelineTier3)record.GetInt(WSIDELINE2)
            ),
            NorthEndzone: new StadiumConfiguration.Endzone(
                Tier1: (StadiumSection.EndzoneTier1)record.GetInt(NENDZONE1),
                Tier2: (StadiumSection.EndzoneTier2)record.GetInt(NENDZONE2),
                Tier3: (StadiumSection.EndzoneTier3)record.GetInt(NENDZONE3)
            ),
            SouthEndzone: new StadiumConfiguration.Endzone(
                Tier1: (StadiumSection.EndzoneTier1)record.GetInt(SENDZONE1),
                Tier2: (StadiumSection.EndzoneTier2)record.GetInt(SENDZONE2),
                Tier3: (StadiumSection.EndzoneTier3)record.GetInt(SENDZONE3)
            ),
            NorthWestCorner: new StadiumConfiguration.Corner(CornerSection: (StadiumSection.Corner)record.GetInt(NWCORNER)),
            NorthEastCorner: new StadiumConfiguration.Corner(CornerSection: (StadiumSection.Corner)record.GetInt(NECORNER)),
            SouthWestCorner: new StadiumConfiguration.Corner(CornerSection: (StadiumSection.Corner)record.GetInt(SWCORNER)),
            SouthEastCorner: new StadiumConfiguration.Corner(CornerSection: (StadiumSection.Corner)record.GetInt(SECORNER)),
            LightType: (StadiumSection.LightType)record.GetInt(LIGHTTYPE),
            RoofType: (StadiumSection.RoofType)record.GetInt(ROOFTYPE)
        )
    );

    public void Save(Stadium item, TableRecord record)
    {
        record.SetInt(CITY, item.CityId);
        record.SetString(NAME, item.Name);
        record.SetInt(AGE, item.Age);
        record.SetInt(RATING, item.Rating);
        record.SetInt(PRACTICE, (int)item.PracticeField);
        record.SetInt(GRASSTYPE, (int)item.Surface);
        
        if (item.Type != StadiumType.Created) return;

        record.SetInt(TOTALCAPACITY, item.TotalCapacity);
        record.SetInt(UPPERENDZONE, item.Capacity.UpperEndZone);
        record.SetInt(LOWERLEVEL, item.Capacity.LowerLevel);
        record.SetInt(LUXURYBOX, item.Capacity.LuxuryBoxes);
        record.SetInt(MIDLEVEL, item.Capacity.MidLevel);
        record.SetInt(UPPERENDZONE, item.Capacity.UpperLevel);
        record.SetInt(CLUBSEAT, item.Capacity.ClubSeats);

        record.SetInt(ESIDELINE1, (int)item.Configuration.EastSideline.Tier1);
        record.SetInt(ESIDELINE2, (int)item.Configuration.EastSideline.Tier2);
        record.SetInt(ESIDELINE3, (int)item.Configuration.EastSideline.Tier3);

        record.SetInt(WSIDELINE1, (int)item.Configuration.WestSideline.Tier1);
        record.SetInt(WSIDELINE2, (int)item.Configuration.WestSideline.Tier2);
        record.SetInt(WSIDELINE3, (int)item.Configuration.WestSideline.Tier3);

        record.SetInt(NENDZONE1, (int)item.Configuration.NorthEndzone.Tier1);
        record.SetInt(NENDZONE2, (int)item.Configuration.NorthEndzone.Tier2);
        record.SetInt(NENDZONE3, (int)item.Configuration.NorthEndzone.Tier3);

        record.SetInt(SENDZONE1, (int)item.Configuration.SouthEndzone.Tier1);
        record.SetInt(SENDZONE2, (int)item.Configuration.SouthEndzone.Tier2);
        record.SetInt(SENDZONE3, (int)item.Configuration.SouthEndzone.Tier3);

        record.SetInt(NWCORNER, (int)item.Configuration.NorthWestCorner.CornerSection);
        record.SetInt(NECORNER, (int)item.Configuration.NorthEastCorner.CornerSection);
        record.SetInt(SWCORNER, (int)item.Configuration.SouthWestCorner.CornerSection);
        record.SetInt(SECORNER, (int)item.Configuration.SouthEastCorner.CornerSection);

        record.SetInt(LIGHTTYPE, (int)item.Configuration.LightType);
        record.SetInt(ROOFTYPE, (int)item.Configuration.RoofType);
    }
}