using Madden08.API.Domain.Common;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>DraftPick</c> class represents a draft in the next draft.
/// </summary>
/// <param name="Record">The record identifier.  Used to match for writes.  <strong>Do not change.</strong></param>
/// <param name="PickNumber">The draft pick number, starting from a 0-index.</param>
/// <param name="OwnerId">The current owner team ID.</param>
/// <param name="OriginalOwnerId">The original owner team ID.</param>
public record DraftPick(int Record, int PickNumber, int OwnerId, int OriginalOwnerId): IDomainRecord
{
    /// <summary>
    /// The true overall position of the draft pick.
    /// </summary>
    public int Overall => PickNumber + 1;
    /// <summary>
    /// The draft round the pick is in.
    /// </summary>
    public int Round => Overall / 32;
    /// <summary>
    /// The pick within the draft round the pick is in.
    /// </summary>
    public int Pick => Overall % 32;

    /// <summary>
    /// The textual representation of the draft pick in a round.pick format (eg. 5.2)
    /// </summary>
    public string Display => $"{Round}.{Pick}";

    /// <summary>
    /// Change the owner of the pick to the specified team ID.
    /// </summary>
    /// <param name="teamId">The new owner team ID.</param>
    /// <returns>A new draft pick instance with the new owner ID.</returns>
    public DraftPick WithOwner(int teamId) => this with { OwnerId = teamId };
}