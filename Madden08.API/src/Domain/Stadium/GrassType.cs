using Madden08.API.Domain.Common;

namespace Madden08.API.Domain;

/// <summary>
/// The <c>GrassType</c> enum represents the types of surfaces a stadium can have.
///
/// It exposes the <c>DisplayName()</c> attribute.
/// </summary>
public enum GrassType
{
    /// <summary>Natural</summary>
    [DisplayName("Natural")]
    Natural = 0,

    /// <summary>Artificial</summary>
    [DisplayName("Artifical Turf")]
    Artificial = 1,

    /// <summary>Baseball Diamond</summary>
    [DisplayName("Baseball Diamond")]
    Baseball = 2,

    /// <summary>Grass Turf</summary>
    [DisplayName("Grass Turf")]
    GrassTurf = 3,
}