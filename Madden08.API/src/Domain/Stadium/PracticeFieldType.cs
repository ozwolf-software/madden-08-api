using Madden08.API.Domain.Common;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>PracticeFieldType</c> enum represents where a team would practice at the stadium.
///
/// It exposes the <c>DisplayName()</c> attribute.
/// </summary>
public enum PracticeFieldType
{
    /// <summary>Game Field</summary>
    [DisplayName("Game Field")]
    Game = 0,

    /// <summary>Practice Field</summary>
    [DisplayName("Practice Field")]
    Practice = 1
}