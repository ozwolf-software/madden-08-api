using Madden08.API.Domain.Coach;

namespace Madden08.API.TDB.Table;

internal class CoachTable : ITable<Coach>
{
    private const string TABLE = "COCH";
    private const string ID = "CCID";
    private const string AGE = "CAGE";
    private const string CHEMISTRY = "CCHM";
    private const string SALARY = "CSAL";
    private const string CONTRACT_LENGTH = "CCLN";
    private const string DEFENSE = "CDEF";
    private const string DEFENSIVE_PLAYBOOK = "CDID";
    private const string DEFENSE_AGGRESSION = "CDTA";
    private const string DEFENSE_PASS_PERCENT = "CDTR";
    private const string DEFENSE_BASE_FORMATION = "CDTY";
    private const string WORK_ETHIC = "CETH";
    private const string KNOWLEDGE = "CKNW";
    private const string NAME = "CLNA";
    private const string MOTIVATION = "CMOT";
    private const string OFFENSE = "COFF";
    private const string POSITION = "COPS";
    private const string OFFENSE_AGGRESSION = "COTA";
    private const string OFFENSE_PASS_PERCENT = "COTR";
    private const string OFFENSE_PLAYBOOK = "CPID";
    private const string APPROVAL_RATING = "CRAT";
    private const string RB_CARRY_PERCENT = "CRBT";
    private const string DB_RATING = "CRDB";
    private const string DL_RATING = "CRDL";
    private const string KICK_RATING = "CRKS";
    private const string LB_RATING = "CRLB";
    private const string OL_RATING = "CROL";
    private const string PUNT_RATING = "CRPS";
    private const string QB_RATING = "CRQB";
    private const string RB_RATING = "CRRB";
    private const string S_RATING = "CRSA";
    private const string WR_RATING = "CRWR";
    private const string TEAM_ID = "TGID";

    public string Name => TABLE;

    public Coach Load(TableRecord record) => new(
        record.Record,
        record.GetInt(ID),
        record.GetString(NAME),
        record.GetInt(TEAM_ID),
        (CoachPosition)record.GetInt(POSITION),
        record.GetInt(AGE),
        record.GetInt(SALARY),
        record.GetInt(CONTRACT_LENGTH),
        record.GetInt(APPROVAL_RATING),
        new CoachAttributes(
            record.GetInt(MOTIVATION),
            record.GetInt(WORK_ETHIC),
            record.GetInt(CHEMISTRY),
            record.GetInt(KNOWLEDGE),
            record.GetInt(OFFENSE),
            record.GetInt(DEFENSE),
            record.GetInt(OL_RATING),
            record.GetInt(QB_RATING),
            record.GetInt(RB_RATING),
            record.GetInt(WR_RATING),
            record.GetInt(DL_RATING),
            record.GetInt(LB_RATING),
            record.GetInt(DB_RATING),
            record.GetInt(S_RATING),
            record.GetInt(KICK_RATING),
            record.GetInt(PUNT_RATING)
        ),
        new CoachStrategy(
            (OffensivePlaybook)record.GetInt(OFFENSE_PLAYBOOK),
            record.GetInt(OFFENSE_AGGRESSION),
            record.GetInt(OFFENSE_PASS_PERCENT),
            record.GetInt(RB_CARRY_PERCENT),
            (DefensivePlaybook)record.GetInt(DEFENSIVE_PLAYBOOK),
            record.GetInt(DEFENSE_AGGRESSION),
            record.GetInt(DEFENSE_PASS_PERCENT),
            (DefenseBaseFormation)record.GetInt(DEFENSE_BASE_FORMATION)
        )
    );

    public void Save(Coach item, TableRecord record)
    {
        record.SetString(NAME, item.Name);
        record.SetInt(AGE, item.Age);
        record.SetInt(TEAM_ID, item.TeamId);
        record.SetInt(POSITION, (int)item.Position);
        record.SetInt(SALARY, item.Salary);
        record.SetInt(CONTRACT_LENGTH, item.ContractYearsLeft);
        record.SetInt(APPROVAL_RATING, item.ApprovalRating);
        record.SetInt(MOTIVATION, item.Attributes.Motivation);
        record.SetInt(WORK_ETHIC, item.Attributes.WorkEthic);
        record.SetInt(CHEMISTRY, item.Attributes.Chemistry);
        record.SetInt(KNOWLEDGE, item.Attributes.Knowledge);
        record.SetInt(OFFENSE, item.Attributes.Offense);
        record.SetInt(DEFENSE, item.Attributes.Defense);
        record.SetInt(OL_RATING, item.Attributes.OffensiveLine);
        record.SetInt(QB_RATING, item.Attributes.Quarterbacks);
        record.SetInt(RB_RATING, item.Attributes.RunningBacks);
        record.SetInt(WR_RATING, item.Attributes.WideReceivers);
        record.SetInt(DL_RATING, item.Attributes.DefensiveLine);
        record.SetInt(LB_RATING, item.Attributes.LineBackers);
        record.SetInt(DB_RATING, item.Attributes.DefensiveBacks);
        record.SetInt(S_RATING, item.Attributes.Safeties);
        record.SetInt(KICK_RATING, item.Attributes.Kickers);
        record.SetInt(PUNT_RATING, item.Attributes.Punters);
        record.SetInt(OFFENSE_PLAYBOOK, (int)item.Strategy.OffensePlaybook);
        record.SetInt(OFFENSE_AGGRESSION, item.Strategy.OffenseAggression);
        record.SetInt(OFFENSE_PASS_PERCENT, item.Strategy.OffensePassPercent);
        record.SetInt(RB_CARRY_PERCENT, item.Strategy.RunningBackLoadPercent);
        record.SetInt(DEFENSIVE_PLAYBOOK, (int) item.Strategy.DefensePlaybook);
        record.SetInt(DEFENSE_AGGRESSION, item.Strategy.DefenseAggression);
        record.SetInt(DEFENSE_PASS_PERCENT, item.Strategy.DefensePassPercent);
        record.SetInt(DEFENSE_BASE_FORMATION, (int)item.Strategy.DefenseBaseFormation);
    }
}