using Madden08.API.Domain.Common;
using Madden08.API.Util;

namespace Madden08.API.Domain.Coach;

/// <summary>
/// The <c>Coach</c> class represents a coach record in a Madden file.
/// </summary>
/// <param name="Record">The record identifier.  Used to match for writes.  <strong>Do not change.</strong></param>
/// <param name="Id">The coach ID.</param>
/// <param name="Name">The coach name.</param>
/// <param name="TeamId">The team identifier.</param>
/// <param name="Position">The coaches position.</param>
/// <param name="Age">The coach age.</param>
/// <param name="Salary">The coach salary.</param>
/// <param name="ContractYearsLeft">The contract years left.</param>
/// <param name="ApprovalRating">The coaches current approval rating.</param>
/// <param name="Attributes">The coaches attributes.</param>
/// <param name="Strategy">The coaches strategy.</param>
public record Coach(
    int Record,
    int Id,
    string Name,
    int TeamId,
    CoachPosition Position,
    int Age,
    int Salary,
    int ContractYearsLeft,
    int ApprovalRating,
    CoachAttributes Attributes,
    CoachStrategy Strategy) : IDomainRecord
{
    /// <summary>
    /// Change the coaches name.
    /// </summary>
    /// <param name="name">The new name.</param>
    /// <returns>The updated coach.</returns>
    public Coach WithName(string name) => this with { Name = name };

    /// <summary>
    /// Change the coaches team.
    /// </summary>
    /// <param name="id">The new team ID.</param>
    /// <returns>The updated coach.</returns>
    public Coach WithTeam(int id) => this with { TeamId = id };

    /// <summary>
    /// Change the coaches position.
    /// </summary>
    /// <param name="position">The new position.</param>
    /// <returns>The updated coach.</returns>
    public Coach WithPosition(CoachPosition position) => this with { Position = position };

    /// <summary>
    /// Change the coaches age.
    /// </summary>
    /// <param name="age">The new age.</param>
    /// <returns>The updated coach.</returns>
    public Coach WithAge(int age) => this with { Age = age };

    /// <summary>
    /// Change the coaches contract.
    /// </summary>
    /// <param name="salary">The new salary.</param>
    /// <param name="length">The new contract length.</param>
    /// <returns>The updated coach.</returns>
    public Coach WithContract(int salary, int length) =>
        this with { Salary = salary, ContractYearsLeft = NumberUtils.InRange(1, length, 7) };

    /// <summary>
    /// Change the coaches approval rating.
    /// </summary>
    /// <param name="rating">The new approval rating</param>
    /// <returns>The updated coach.</returns>
    public Coach WithApprovalRating(int rating) => this with { ApprovalRating = NumberUtils.InRange(1, rating, 99) };

    /// <summary>
    /// Change the coaches attributes.
    /// </summary>
    /// <param name="attributes">The new attributes.</param>
    /// <returns>The updated coach.</returns>
    public Coach WithAttributes(CoachAttributes attributes) => this with { Attributes = attributes };

    /// <summary>
    /// Change the coaches strategy.
    /// </summary>
    /// <param name="strategy">The new strategy.</param>
    /// <returns>The updated coach.</returns>
    public Coach WithStrategy(CoachStrategy strategy) => this with { Strategy = strategy };
}