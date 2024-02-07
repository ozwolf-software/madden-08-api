using Madden08.API.Domain.Common;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>TeamType</c> enum represents the team types available in Madden files.
///
/// Exposes the <c>Value()</c> extension.
/// </summary>
public enum TeamType
{
    /// <summary>Current</summary>
    [DisplayName("Current")]
    Current = 0,

    /// <summary>Free Agents</summary>
    [DisplayName("Free Agents")]
    FA = 1,

    /// <summary>Historical</summary>
    [DisplayName("Historical")]
    Historical = 2,

    /// <summary>Created</summary>
    [DisplayName("Created")]
    Created = 5,

    /// <summary>Europe</summary>
    [DisplayName("Europe")]
    Europe = 7,

    /// <summary>Pro Bowl</summary>
    [DisplayName("Pro Bowl")]
    ProBowl = 16
}