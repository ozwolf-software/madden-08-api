namespace Madden08.API.Domain.Common;

/// <summary>
/// The <c>DisplayNameAttribute</c> allows fields to be assigned a name for display attribute.
/// </summary>
/// <param name="value">The name value.</param>
[AttributeUsage(AttributeTargets.Field)]
internal class DisplayNameAttribute(string value): Attribute
{
    /// <summary>
    /// The display name value.
    /// </summary>
    public string Value { get; } = value;
}