using Madden08.API.Domain.Common;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>City</c> class represents a city within the game that a team can play from.
/// </summary>
/// <param name="Record">The record identifier.  Used to match for writes.  <strong>Do not change.</strong></param>
/// <param name="ID">The city ID.</param>
/// <param name="Name">The city name.</param>
/// <param name="Population">The city population.</param>
/// <param name="OwnerMode">The flag indicating if the city can be used in franchises.</param>
/// <param name="State">The state the city is in.</param>
/// <param name="Region">The region the city is in(affects weather).</param>
/// <see cref="CityRegion"/>
/// 
public record City(int Record, int ID, string Name, int Population, bool OwnerMode, string State, CityRegion Region) : IDomainRecord
{
    /// <summary>
    /// Change the city population.
    /// </summary>
    /// <param name="population">The new population.</param>
    /// <returns>A new city instance with the new population.</returns>
    public City WithPopulation(int population) => this with { Population = population };

    /// <summary>
    /// Change the owner mode flag.
    /// </summary>
    /// <param name="flag">The flag value.</param>
    /// <returns>A new city instance with the new owner mode flag.</returns>
    public City WithOwnerMode(bool flag) => this with { OwnerMode = flag };

    /// <summary>
    /// Change the city's name and/or region.
    /// </summary>
    /// <param name="name">The (optional) city name.</param>
    /// <param name="region">The (optional) region  .</param>
    /// <returns>A new city instance with the changed name and/or region.</returns>
    public City ChangeTo(string? name = null, CityRegion? region = null) => this with
    {
        Name = name ?? Name,
        Region = region ?? Region
    };
}