using Madden08.API.Util;

namespace Madden08.API.Domain.Coach;

/// <summary>
/// The <c>CoachAttributes</c> class represents a coaches current ratings.
/// </summary>
/// <param name="Motivation">The ability to motivate.</param>
/// <param name="WorkEthic">The coaches work ethic.</param>
/// <param name="Chemistry">The chemistry a coach brings to a team.</param>
/// <param name="Knowledge">The coaches game knowledge.</param>
/// <param name="Offense">The coaches offensive coaching skills.</param>
/// <param name="Defense">The coaches defensive coaching skills.</param>
/// <param name="OffensiveLine">The coaches offensive line position coaching skills.</param>
/// <param name="Quarterbacks">The coaches quarterback position coaching skills.</param>
/// <param name="RunningBacks">The coaches running back position coaching skills.</param>
/// <param name="WideReceivers">The coaches wide receiver position coaching skills.</param>
/// <param name="DefensiveLine">The coaches defensive line position coaching skills.</param>
/// <param name="LineBackers">The coaches linebacker position coaching skills.</param>
/// <param name="DefensiveBacks">The coaches defensive backs position coaching skills.</param>
/// <param name="Safeties">The coaches safety position coaching skills.</param>
/// <param name="Kickers">The coaches kicker position coaching skills.</param>
/// <param name="Punters">The coaches punter position coaching skills.</param>
public record CoachAttributes(
    int Motivation,
    int WorkEthic,
    int Chemistry,
    int Knowledge,
    int Offense,
    int Defense,
    int OffensiveLine,
    int Quarterbacks,
    int RunningBacks,
    int WideReceivers,
    int DefensiveLine,
    int LineBackers,
    int DefensiveBacks,
    int Safeties,
    int Kickers,
    int Punters)
{
    /// <summary>
    /// Change the coach motivation skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithMotivation(int rating) => this with { Motivation = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach work ethic skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithWorkEthic(int rating) => this with { WorkEthic = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach chemistry skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithChemistry(int rating) => this with { Chemistry = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach knowledge skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithKnowledge(int rating) => this with { Knowledge = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach offense skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithOffense(int rating) => this with { Offense = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach defense skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithDefense(int rating) => this with { Defense = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach offensive line skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithOffensiveLine(int rating) => this with { OffensiveLine= NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach quarterbacks skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithQuarterbacks(int rating) => this with { Quarterbacks = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach running backs skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithRunningBacks(int rating) => this with { RunningBacks = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach wide receivers skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithWideReceivers(int rating) => this with { WideReceivers = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach defensive line skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithDefensiveLine(int rating) => this with { DefensiveLine = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach linebackers skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithLineBackers(int rating) => this with { LineBackers = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach defensive backs skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithDefensiveBacks(int rating) => this with { DefensiveBacks = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach safeties skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithSafeties(int rating) => this with { Safeties = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach kickers skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithKickers(int rating) => this with { Kickers = NumberUtils.InRange(0, rating, 99) };

    /// <summary>
    /// Change the coach punters skill.
    /// </summary>
    /// <param name="rating">The new rating.</param>
    /// <returns>The updated attributes.</returns>
    public CoachAttributes WithPunters(int rating) => this with { Punters = NumberUtils.InRange(0, rating, 99) };
}