using Madden08.API.Domain.Common;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>StadiumType</c> enum represents the types of stadium in the game file.
///
/// It exposes the <c>DisplayName()</c> attribute.
/// </summary>
public enum StadiumType
{
    /// <summary>Current</summary>
    [DisplayName("Current")]
    Current = 0,

    /// <summary>Created</summary>
    [DisplayName("Created")]
    Created = 1,

    /// <summary>Fantasy</summary>
    [DisplayName("Fantasy")]
    Fantasy = 2
}