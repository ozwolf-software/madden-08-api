using Madden08.API.Domain;

namespace Madden08.API.TDB.Table;

internal record PlayerTable : ITable<Player>
{
    private const string TABLE = "PLAY";
    private const string ID = "PGID";
    private const string FIRSTNAME = "PFNA";
    private const string LASTNAME = "PLNA";
    private const string TEAM = "TGID";
    private const string POSITION = "PPOS";
    private const string AGE = "PAGE";
    private const string COLLEGE = "PCOL";
    private const string MORALE = "PMOR";
    private const string ALLSTAR = "PFPB";
    private const string ICON = "PICN";
    private const string TOTALSALARY = "PTSA";
    private const string TOTALBONUS = "PSBO";
    private const string JERSEYNUMBER = "PJEN";
    private const string SALARYYEAR1 = "PSA0";
    private const string SALARYYEAR2 = "PSA1";
    private const string SALARYYEAR3 = "PSA2";
    private const string SALARYYEAR4 = "PSA3";
    private const string SALARYYEAR5 = "PSA4";
    private const string SALARYYEAR6 = "PSA5";
    private const string SALARYYEAR7 = "PSA6";
    private const string BONUSYEAR1 = "PSB0";
    private const string BONUSYEAR2 = "PSB1";
    private const string BONUSYEAR3 = "PSB2";
    private const string BONUSYEAR4 = "PSB3";
    private const string BONUSYEAR5 = "PSB4";
    private const string BONUSYEAR6 = "PSB5";
    private const string BONUSYEAR7 = "PSB6";
    private const string CONTRACTLENGTH = "PCON";
    private const string CONTRACTLEFT = "PCYL";
    private const string YEARSPRO = "PYRP";
    private const string TENDENCY = "PTEN";
    private const string DRAFTROUND = "PDRO";
    private const string DRAFTPICK = "PDPI";
    private const string HEIGHT = "PHGT";
    private const string WEIGHT = "PWGT";
    private const string OVR = "POVR";
    private const string SPD = "PSPD";
    private const string STR = "PSTR";
    private const string AWR = "PAWR";
    private const string AGI = "PAGI";
    private const string ACC = "PACC";
    private const string CTH = "PCTH";
    private const string CAR = "PCAR";
    private const string JMP = "PJMP";
    private const string BTK = "PBTK";
    private const string TAK = "PTAK";
    private const string THP = "PTHP";
    private const string THA = "PTHA";
    private const string PBK = "PPBK";
    private const string RBK = "PRBK";
    private const string KPW = "PKPW";
    private const string KAC = "PKAC";
    private const string STA = "PSTA";
    private const string INJ = "PINJ";
    private const string IMP = "PIMP";
    private const string TGH = "PTGH";
    private const string KIR = "PKIR";

    private const int MoneyFactor = 10000;

    public string Name => TABLE;

    public Player Load(TableRecord record) => new(
        Record: record.Record,
        Id: record.GetInt(ID),
        FirstName: record.GetString(FIRSTNAME),
        LastName: record.GetString(LASTNAME),
        Position: (PlayerPosition)record.GetInt(POSITION),
        DraftInformation: new PlayerDraftInformation(
            College: (College)record.GetInt(COLLEGE),
            Round: record.GetInt(DRAFTROUND),
            Pick: record.GetInt(DRAFTPICK)
        ),
        Age: record.GetInt(AGE),
        Height: record.GetInt(HEIGHT),
        Weight: record.GetInt(WEIGHT),
        YearsPro: record.GetInt(YEARSPRO),
        Morale: record.GetInt(MORALE),
        ProBowler: record.GetInt(ALLSTAR) > 0,
        Icon: record.GetInt(ICON) > 0,
        TeamId: record.GetInt(TEAM),
        Contract: new PlayerContract(
            TotalSalary: record.GetInt(TOTALSALARY) * MoneyFactor,
            TotalBonus: record.GetInt(TOTALBONUS) * MoneyFactor,
            Length: record.GetInt(CONTRACTLENGTH),
            YearsLeft: record.GetInt(CONTRACTLEFT),
            Salaries:
            [
                new PlayerSalary(Year: 1, Salary: record.GetInt(SALARYYEAR1) * MoneyFactor, Bonus: record.GetInt(BONUSYEAR1) * MoneyFactor),
                new PlayerSalary(Year: 2, Salary: record.GetInt(SALARYYEAR2) * MoneyFactor, Bonus: record.GetInt(BONUSYEAR2) * MoneyFactor),
                new PlayerSalary(Year: 3, Salary: record.GetInt(SALARYYEAR3) * MoneyFactor, Bonus: record.GetInt(BONUSYEAR3) * MoneyFactor),
                new PlayerSalary(Year: 4, Salary: record.GetInt(SALARYYEAR4) * MoneyFactor, Bonus: record.GetInt(BONUSYEAR4) * MoneyFactor),
                new PlayerSalary(Year: 5, Salary: record.GetInt(SALARYYEAR5) * MoneyFactor, Bonus: record.GetInt(BONUSYEAR5) * MoneyFactor),
                new PlayerSalary(Year: 6, Salary: record.GetInt(SALARYYEAR6) * MoneyFactor, Bonus: record.GetInt(BONUSYEAR6) * MoneyFactor),
                new PlayerSalary(Year: 7, Salary: record.GetInt(SALARYYEAR7) * MoneyFactor, Bonus: record.GetInt(BONUSYEAR7) * MoneyFactor),
            ]
        ),
        JerseyNumber: record.GetInt(JERSEYNUMBER),
        Attributes: new PlayerAttributes(
            OVR: record.GetInt(OVR),
            SPD: record.GetInt(SPD),
            STR: record.GetInt(STR),
            AWR: record.GetInt(AWR),
            AGI: record.GetInt(AGI),
            ACC: record.GetInt(ACC),
            CTH: record.GetInt(CTH),
            CAR: record.GetInt(CAR),
            JMP: record.GetInt(JMP),
            BTK: record.GetInt(BTK),
            TAK: record.GetInt(TAK),
            THP: record.GetInt(THP),
            THA: record.GetInt(THA),
            PBK: record.GetInt(PBK),
            RBK: record.GetInt(RBK),
            KPW: record.GetInt(KPW),
            KAC: record.GetInt(KAC),
            STA: record.GetInt(STA),
            INJ: record.GetInt(INJ),
            IMP: record.GetInt(IMP),
            TGH: record.GetInt(TGH),
            KR: record.GetInt(KIR)
        )
    );

    public void Save(Player item, TableRecord record)
    {
        record.SetInt(POSITION, (int)item.Position);
        record.SetInt(COLLEGE, (int)item.DraftInformation.College);
        record.SetInt(DRAFTROUND, item.DraftInformation.Round);
        record.SetInt(DRAFTPICK, item.DraftInformation.Pick);
        record.SetInt(WEIGHT, item.Weight);
        record.SetInt(MORALE, item.Morale);
        record.SetInt(ALLSTAR, item.ProBowler ? 1 : 0);
        record.SetInt(ICON, item.Icon ? 1 : 0);
        record.SetInt(TEAM, item.TeamId);
        record.SetInt(CONTRACTLENGTH, item.Contract.Length);
        record.SetInt(CONTRACTLEFT, item.Contract.YearsLeft);
        
        var year1 = item.Contract.GetSalary(1);
        var year2 = item.Contract.GetSalary(2);
        var year3 = item.Contract.GetSalary(3);
        var year4 = item.Contract.GetSalary(4);
        var year5 = item.Contract.GetSalary(5);
        var year6 = item.Contract.GetSalary(6);
        var year7 = item.Contract.GetSalary(7);

        record.SetInt(SALARYYEAR1, year1.Salary);
        record.SetInt(SALARYYEAR2, year2.Salary);
        record.SetInt(SALARYYEAR3, year3.Salary);
        record.SetInt(SALARYYEAR4, year4.Salary);
        record.SetInt(SALARYYEAR5, year5.Salary);
        record.SetInt(SALARYYEAR6, year6.Salary);
        record.SetInt(SALARYYEAR7, year7.Salary);

        record.SetInt(BONUSYEAR1, year1.Bonus);
        record.SetInt(BONUSYEAR2, year2.Bonus);
        record.SetInt(BONUSYEAR3, year3.Bonus);
        record.SetInt(BONUSYEAR4, year4.Bonus);
        record.SetInt(BONUSYEAR5, year5.Bonus);
        record.SetInt(BONUSYEAR6, year6.Bonus);
        record.SetInt(BONUSYEAR7, year7.Bonus);
    }
}