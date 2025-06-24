using Madden08.API.Util;

namespace Madden08.API.Domain.Coach;

/// <summary>
/// The <c>Coach Strategy</c> class represents a coach record strategy setup from the Madden file.
/// </summary>
/// <param name="OffensePlaybook">The offensive playbook for the coach.</param>
/// <param name="OffenseAggression">The offensive aggression for the coach.</param>
/// <param name="OffensePassPercent">The offensive pass percent for the coach.</param>
/// <param name="RunningBackLoadPercent">The offensive running back load percent for the coach.</param>
/// <param name="DefensePlaybook">The offensive defensive playbook for the coach.</param>
/// <param name="DefenseAggression">The defensive aggression for the coach.</param>
/// <param name="DefensePassPercent">The defensive pass percent for the coach.</param>
/// <param name="DefenseBaseFormation">The defensive base baseFormation for the coach.</param>
public record CoachStrategy(
    OffensivePlaybook OffensePlaybook,
    int OffenseAggression,
    int OffensePassPercent,
    int RunningBackLoadPercent,
    DefensivePlaybook DefensePlaybook,
    int DefenseAggression,
    int DefensePassPercent,
    DefenseBaseFormation DefenseBaseFormation)
{
    /// <summary>
    /// Change the coaches offensive playbook.
    /// </summary>
    /// <param name="playbook">The new playbook.</param>
    /// <returns>The updated coach strategy</returns>
    public CoachStrategy WithOffensePlaybook(OffensivePlaybook playbook) => this with { OffensePlaybook = playbook };

    /// <summary>
    /// Change the coaches offensive aggression.
    /// </summary>
    /// <param name="value">The new value.</param>
    /// <returns>The updated coach strategy</returns>
    public CoachStrategy WithOffenseAggression(int value) => this with { OffenseAggression = NumberUtils.InRange(21, value, 79) };

    /// <summary>
    /// Change the coaches offensive pass percentage.
    /// </summary>
    /// <param name="value">The new value.</param>
    /// <returns>The updated coach strategy</returns>
    public CoachStrategy WithOffensePassPercent(int value) => this with { OffensePassPercent = NumberUtils.InRange(21, value, 79) };

    /// <summary>
    /// Change the coaches offensive running back load percentage.
    /// </summary>
    /// <param name="value">The new value.</param>
    /// <returns>The updated coach strategy</returns>
    public CoachStrategy WithRunningBackLoadPercent(int value) => this with { RunningBackLoadPercent = NumberUtils.InRange(50, value, 90) };

    /// <summary>
    /// Change the coaches defensive playbook.
    /// </summary>
    /// <param name="playbook">The new playbook.</param>
    /// <returns>The updated coach strategy</returns>
    public CoachStrategy WithDefensePlaybook(DefensivePlaybook playbook) => this with { DefensePlaybook = playbook };

    /// <summary>
    /// Change the coaches defensive aggression.
    /// </summary>
    /// <param name="value">The new value.</param>
    /// <returns>The updated coach strategy</returns>
    public CoachStrategy WithDefenseAggression(int value) => this with { DefenseAggression = NumberUtils.InRange(21, value, 79) };

    /// <summary>
    /// Change the coaches defensive pass percentage.
    /// </summary>
    /// <param name="value">The new value.</param>
    /// <returns>The updated coach strategy</returns>
    public CoachStrategy WithDefensePassPercent(int value) => this with { DefensePassPercent = NumberUtils.InRange(21, value, 79) };

    /// <summary>
    /// Change the coaches defensive base formation.
    /// </summary>
    /// <param name="formation">The new base formation.</param>
    /// <returns>The updated coach strategy</returns>
    public CoachStrategy WithDefenseBaseFormation(DefenseBaseFormation formation) => this with { DefenseBaseFormation = formation};
};