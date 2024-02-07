using Madden08.API.Domain.Common;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>Stadium</c> class represents a stadium, either current or created, along with its age, rating and configuration.
/// </summary>
/// <param name="Record">The record identifier.  Used to match for writes.  <strong>Do not change.</strong></param>
/// <param name="ID">The stadium ID.</param>
/// <param name="Name">The name of the stadium.</param>
/// <param name="CityId">The city ID the stadium resides in.</param>
/// <param name="Age">The stadium age in years.</param>
/// <param name="Rating">The stadium rating out of 99.</param>
/// <param name="PracticeField">What type of practice field the stadium has.</param>
/// <param name="Type">The stadium type.</param>
/// <param name="Surface">What type of surface the stadium has.</param>
/// <param name="Capacity">The seat type breakdown of the stadium capacity.</param>
/// <param name="Configuration">The stadium configuration.</param>
public record Stadium(int Record, int ID, string Name, int CityId, int Age, int Rating, PracticeFieldType PracticeField, StadiumType Type, GrassType Surface, Capacity Capacity, StadiumConfiguration Configuration): IDomainRecord
{
    /// <summary>
    /// The total capacity of the stadium.
    /// </summary>
    public int TotalCapacity => Capacity.Total;

    /// <summary>
    /// Change the name of the stadium.
    /// </summary>
    /// <param name="name">The new stadium name.</param>
    /// <returns>A new stadium instance with the updated name.</returns>
    public Stadium WithName(string name) => this with { Name = name };

    /// <summary>
    /// Change the stadium age.
    /// </summary>
    /// <param name="age">The new stadium age.</param>
    /// <returns>A new stadium instance with updated age.</returns>
    public Stadium WithAge(int age) => this with { Age = age };

    /// <summary>
    /// Chane the stadium rating.
    /// </summary>
    /// <param name="rating">The new stadium rating.</param>
    /// <returns>A new stadium instance with updated rating.</returns>
    public Stadium WithRating(int rating) => this with { Rating = rating };

    /// <summary>
    /// Change the type of practice field the stadium has.
    /// </summary>
    /// <param name="type">The type of practice field.</param>
    /// <returns>A new stadium instance with the updated practice field.</returns>
    public Stadium WithPracticeField(PracticeFieldType type) => this with { PracticeField = type };

    /// <summary>
    /// Change the surface the stadium has.
    /// </summary>
    /// <param name="surface">The new surface</param>
    /// <returns>A new stadium instance with the updated surface.</returns>
    public Stadium WithSurface(GrassType surface) => this with { Surface = surface };

    /// <summary>
    /// Update the stadium configuration.
    /// </summary>
    /// <param name="modifier">The configuration modifier function.</param>
    /// <returns>A new stadium instance with the new configuration.</returns>
    /// <exception cref="InvalidDataException">If attempting to change the configuration on anything except a created stadium.</exception>
    public Stadium WithConfiguration(Func<StadiumConfiguration, StadiumConfiguration> modifier)
    {
        if (this.Type != StadiumType.Created) throw new InvalidDataException("Cannot change configuration of an existing current stadium.");
        
        var newConfiguration = modifier(this.Configuration);
        return this with { Configuration = newConfiguration, Capacity = newConfiguration.Capacity };
    }

    /// <summary>
    /// Move the stadium to the given city.
    /// </summary>
    /// <param name="cityId">The city identifier.</param>
    /// <returns>A new stadium instance that has moved to the new city.</returns>
    public Stadium MoveTo(int cityId) => this with { CityId = cityId };
}