using Madden08.API.Domain.Common;

namespace Madden08.API.Domain;

/// <summary>
/// A <c>Team</c> class represents a team in the Madden franchise or roster file.
/// </summary>
/// <param name="Record">The record identifier.  Used to match for writes.  <strong>Do not change.</strong></param>
/// <param name="Id">The team ID.</param>
/// <param name="Type">The team type.</param>
/// <param name="Name">The team name (eg. Pittsburgh)</param>
/// <param name="NickName">The team nickname (eg. Steelers)</param>
/// <param name="ShortName">The team short name (eg. PIT)</param>
/// <param name="OtherName">The team alternative name.</param>
/// <param name="CityId">The city ID the team is in.</param>
/// <param name="StadiumId">The stadium ID the team plays in.</param>
/// <param name="Division">The division the team competes in.</param>
/// <param name="SalaryCap">The teams current salary cap position.</param>
/// <param name="CurrentCapPenalty">The teams cap penalty position for this season.</param>
/// <param name="NextYearCapPenalty">The teams cap penalty position for next season.</param>
public record Team(int Record, int Id, TeamType Type, string Name, string NickName, string ShortName, string OtherName, int CityId, int StadiumId, Division Division, int SalaryCap, int CurrentCapPenalty, int NextYearCapPenalty): IDomainRecord
{
    internal static readonly int FreeAgencyTeamId = 1009;

    /// <summary>
    /// The conference the team competes in.
    /// </summary>
    public Conference Conference => this.Division.Conference();

    /// <summary>
    /// Change a teams name.
    /// </summary>
    /// <example>
    /// <c>team.WithName(nickName: "Tests", otherName: "Tests");</c>
    /// </example>
    /// <param name="name">The (optional) team name.</param>
    /// <param name="nickName">The (optional) nick name.</param>
    /// <param name="shortName">The (optional) short name.</param>
    /// <param name="otherName">The (optional) alternative name.</param>
    /// <returns>A new team instance with the modified names.</returns>
    public Team WithName(string? name = null, string? nickName = null, string? shortName = null, string? otherName = null) => this with
    {
        Name = name ?? Name,
        NickName = nickName ?? NickName,
        ShortName = shortName ?? ShortName,
        OtherName = otherName ?? OtherName
    };

    /// <summary>
    /// Adjust the teams salary cap position by the given amount (+ or - values allowed)
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new team instance with the adjusted salary cap position.</returns>
    public Team AdjustSalaryCap(int adjustment) => this with { SalaryCap = SalaryCap + adjustment };

    /// <summary>
    /// Adjust next years cap penalty postion by the given amount (+ or - values allowed)
    /// </summary>
    /// <param name="adjustment">The adjustment amount.</param>
    /// <returns>A new team instance with the adjusted cap penalty for next year.</returns>
    public Team AdjustNextYearCapPenalty(int adjustment) => this with { NextYearCapPenalty = NextYearCapPenalty + adjustment };

    /// <summary>
    /// Move the team to a new city.
    /// </summary>
    /// <param name="cityId">The city ID to move to.</param>
    /// <returns>A new team instance in the new city.</returns>
    public Team MoveTo(int cityId) => this with { CityId = cityId };

    /// <summary>
    /// Move the team to a new stadium.
    /// </summary>
    /// <param name="stadiumId">The stadium ID to play in.</param>
    /// <returns>A new team instance in the new stadium.</returns>
    public Team PlayIn(int stadiumId) => this with { StadiumId = stadiumId };
}