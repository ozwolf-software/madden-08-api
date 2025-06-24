namespace Madden08.API.Domain;


/// <summary>
/// The <c>PlayerDraftInformation</c> class represents a players education and drafted position when they entered the league.
///
/// An un-drafted player will 0 for round and pick.
/// </summary>
/// <param name="College">The players education institution.</param>
/// <param name="Round">The players draft round.</param>
/// <param name="Pick">The players draft pick.</param>
public record PlayerDraftInformation(College College, int Round, int Pick)
{
    /// <summary>
    /// The display value of their drafted position.  Shows N/A for un-drafted.
    /// </summary>
    public string DraftDisplay => Round > 0 ? $"{Round}.{Pick}" : "N/A";

    /// <summary>
    /// Record when the player was drafted.
    /// </summary>
    /// <param name="round">The draft round.</param>
    /// <param name="pick">The draft round pick.</param>
    /// <returns>A new player draft information instance with the draft rounds.</returns>
    public PlayerDraftInformation Drafted(int round, int pick) => this with { Round = round, Pick = pick };
}