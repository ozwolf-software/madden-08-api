using Madden08.API.Domain.Common;
using Madden08.API.Util;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>Division</c> enum represents the divisions in the game engine.
/// </summary>
/// <remarks>
/// Exposes the <c>Value()</c> and <c>Conference()</c> extensions.
/// </remarks>

// ReSharper disable InconsistentNaming
public enum Division
{
    /// <summary>AFC North</summary>
    [DisplayName("AFC North"), Conference(Conference.AFC)]
    AFCNorth = 0,

    /// <summary>AFC South</summary>
    [DisplayName("AFC South"), Conference(Conference.AFC)]
    AFCSouth = 1,

    /// <summary>AFC East</summary>
    [DisplayName("AFC East"), Conference(Conference.AFC)]
    AFCEast = 2,

    /// <summary>AFC West</summary>
    [DisplayName("AFC West"), Conference(Conference.AFC)]
    AFCWest = 3,

    /// <summary>NFC North</summary>
    [DisplayName("NFC North"), Conference(Conference.NFC)]
    NFCNorth = 4,

    /// <summary>NFC South</summary>
    [DisplayName("NFC South"), Conference(Conference.NFC)]
    NFCSouth = 5,

    /// <summary>NFC East</summary>
    [DisplayName("NFC East"), Conference(Conference.NFC)]
    NFCEast = 6,

    /// <summary>NFC West</summary>
    [DisplayName("NFC West"), Conference(Conference.NFC)]
    NFCWest = 7,

    /// <summary>None</summary>
    [DisplayName("None"), Conference(Conference.None)]
    None = 31,
}

/// <summary>
/// The <c>DivisionExtensions</c> class adds utility functions to the <c>Division</c> enum.
/// </summary>
public static class DivisionExtensions
{
    /// <summary>
    /// Expose the conference attribute on the <c>Division</c> enum.
    /// </summary>
    /// <example>
    /// <c>Division.AFCNorth.Conference(); // will return Conference.AFC</c>
    /// </example>
    /// <param name="division">The division instance.</param>
    /// <returns>The <c>Conference</c> attribute value.</returns>
    public static Conference Conference(this Division division) => division.GetAttribute<ConferenceAttribute>().Conference;
}