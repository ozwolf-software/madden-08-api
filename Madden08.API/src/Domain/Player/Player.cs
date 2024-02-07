using Madden08.API.Domain.Common;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>Player</c> class represents a player record from the Madden file.
/// </summary>
/// <param name="Record">The record identifier.  Used to match for writes.  <strong>Do not change.</strong></param>
/// <param name="ID">The player ID.</param>
/// <param name="FirstName">The players first name.</param>
/// <param name="LastName">The players last name.</param>
/// <param name="Position">The players position played.</param>
/// <param name="DraftInformation">The players draft information.</param>
/// <param name="Age">The players age.</param>
/// <param name="Height">The players height in inches.</param>
/// <param name="Weight">The players weight in lbs.</param>
/// <param name="YearsPro">The total years pro of the player.</param>
/// <param name="Morale">The players morale from 0 to 99.</param>
/// <param name="ProBowler">The flag indicating if the player is a pro bowler.</param>
/// <param name="Icon">The flag indicating if the player is an icon.</param>
/// <param name="TeamId">The identifier of the team the player plays for.</param>
/// <param name="Contract">The players contract.</param>
/// <param name="JerseyNumber">The players jersey number.</param>
/// <param name="Attributes">The players ratings.</param>
public record Player(int Record, int ID, string FirstName, string LastName, PlayerPosition Position, PlayerDraftInformation DraftInformation, int Age, int Height, int Weight, int YearsPro, int Morale, bool ProBowler, bool Icon, int TeamId, PlayerContract Contract, int JerseyNumber, PlayerAttributes Attributes): IDomainRecord
{
    /// <summary>
    /// Provide a feet and inches display of the height.
    /// </summary>
    public string HeightDisplay
    {
        get
        {
            var feet = Height / 12;
            var inches = Height % 12;
            return $"{feet}'{inches}\"";
        }
    }

    /// <summary>
    /// Release a player from their team.  This will change their team ID to the free agents and zero out their contract.
    ///
    /// Do this after applying any cap penalty to the team they are leaving.
    /// </summary>
    /// <returns>An updated player instance released from their team.</returns>
    public Player Released() => this with { TeamId = Team.FreeAgencyTeamId, Contract = PlayerContract.Zero };

    /// <summary>
    /// Trade the player to a new team.
    ///
    /// Their contract will have the bonus cleared.
    /// </summary>
    /// <param name="teamId">The new team the player plays for.</param>
    /// <returns>An updated player instance traded to the new team.</returns>
    public Player TradedTo(int teamId) => this with { TeamId = teamId, Contract = this.Contract.ClearBonus() };

    /// <summary>
    /// Sign a player.  If they are changing teams, you can optionally supply a new team ID.
    /// </summary>
    /// <param name="contract">The new player contract.</param>
    /// <param name="teamId">The new (optional) team the player is playing for.</param>
    /// <returns>A new player instance signed to a team.</returns>
    public Player SignTo(PlayerContract contract, int? teamId = null) => this with { TeamId = teamId ?? TeamId, Contract = contract };

    /// <summary>
    /// Resets a players morale to 99.
    /// </summary>
    /// <returns>A new player instance with morale at 99.</returns>
    public Player ResetMorale() => this with { Morale = 99 };

    /// <summary>
    /// Toggles whether the player is a pro bowler or not.
    /// </summary>
    /// <param name="flag">The flag.</param>
    /// <returns>A new player instance with an updated pro bowler flag.</returns>
    public Player IsProBowler(bool flag) => this with { ProBowler = flag };

    /// <summary>
    /// Toggles whether the player is an icon or not.
    /// </summary>
    /// <param name="flag">The flag.</param>
    /// <returns>A new player instance with an updated icon flag.</returns>
    public Player IsIcon(bool flag) => this with { Icon = flag };

    /// <summary>
    /// Change the position the player is on the roster.
    /// </summary>
    /// <param name="position">The new position.</param>
    /// <returns>A new player instance with the updated position.</returns>
    public Player ChangePosition(PlayerPosition position) => this with { Position = position };

    /// <summary>
    /// Updates the player with a drafted position.
    /// </summary>
    /// <param name="round">The draft round.</param>
    /// <param name="pick">The draft round pick.</param>
    /// <returns>A new player instance with the updated draft information.</returns>
    public Player Drafted(int round, int pick) => this with { DraftInformation = DraftInformation.Drafted(round, pick) };

    /// <summary>
    /// Update the players ratings.
    /// </summary>
    /// <param name="modifier">The players attribute ratings modifier.</param>
    /// <returns>A new player instance with the new attribute ratings.</returns>
    public Player WithAttributes(Func<PlayerAttributes, PlayerAttributes> modifier) => this with { Attributes = modifier(Attributes)};

    /// <summary>
    /// Adjust the players weight by the supplied lbs.
    /// </summary>
    /// <param name="adjustment">The weight adjustment in lbs.</param>
    /// <returns>A new player instance with the adjusted weight.</returns>
    public Player AdjustWeight(int adjustment) => this with { Weight = Weight + adjustment };

    /// <summary>
    /// Update the players jersey number.
    /// </summary>
    /// <param name="number">The new jersey number.</param>
    /// <returns>A new player instance with the updated jersey number.</returns>
    public Player WithJerseyNumber(int number) => this with { JerseyNumber = number };
}