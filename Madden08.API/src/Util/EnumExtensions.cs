using Madden08.API.Domain.Common;

namespace Madden08.API.Util;

/// <summary>
/// The <c>EnumExtensions</c> class exposes universal extension functions for <c>Enum types.</c>
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Return the <c>Value</c> attribute on an enum field.
    /// </summary>
    /// <param name="value">The enum instance.</param>
    /// <returns>The display name value.</returns>
    /// <see cref="DisplayNameAttribute"/>
    public static string DisplayName(this Enum value) => value.GetAttribute<DisplayNameAttribute>().Value;
}