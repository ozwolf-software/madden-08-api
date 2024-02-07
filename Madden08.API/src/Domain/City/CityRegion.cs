using Madden08.API.Domain.Common;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>CityRegion</c> enum represents the possible regions cities can be based in.
///
/// If modifying a city to one outside of the United States, select a region that is a best-approximation of that city's climate.
///
/// Exposes the <c>Value()</c> extension;
/// </summary>
public enum CityRegion
{
    /// <summary>None</summary>
    [DisplayName("None")]
    None = 0,
    /// <summary>South West</summary>
    [DisplayName("South West")]
    SouthWest = 1,
    /// <summary>South East</summary>
    [DisplayName("South East")]
    SouthEast = 2,
    /// <summary>North East</summary>
    [DisplayName("North East")]
    NorthEast = 3,
    /// <summary>North West</summary>
    [DisplayName("North West")]
    NorthWest = 4,
    /// <summary>Mid West</summary>
    [DisplayName("Mid West")]
    MidWest = 5
}