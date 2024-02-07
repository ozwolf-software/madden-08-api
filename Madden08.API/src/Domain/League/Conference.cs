using Madden08.API.Domain.Common;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>Conference</c> enum represents the conferences configured in the game engine.
///
/// Exposes the <c>Value()</c> extension;
/// </summary>
public enum Conference
{
    /// <summary>AFC</summary>
    [DisplayName("AFC")]
    AFC = 0,
    /// <summary>NFC</summary>
    [DisplayName("NFC")]
    NFC = 1,
    /// <summary>None</summary>
    [DisplayName("None")]
    None = 3
}

/// <summary>
/// The <c>ConferenceAttribute</c> class allows fields to be given extra attributes.
///
/// This attribute is primarily defined to allow the <c>Division</c> enum to be tagged with the conference they are in.
/// </summary>
/// <param name="conference">The conference.</param>
[AttributeUsage(AttributeTargets.Field)]
internal class ConferenceAttribute(Conference conference) : Attribute
{
    /// <summary>The conference value</summary>
    public Conference Conference { get; set; } = conference;
}