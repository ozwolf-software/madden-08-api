namespace Madden08.API.Util;

internal static class ObjectExtensions
{
    internal static T GetAttribute<T>(this object value, T? defaultValue = null) where T : Attribute
    {
        var type = value.GetType();
        var fieldInfo = type.GetField(value.ToString() ?? string.Empty) ?? throw new InvalidOperationException($"Error getting attribute from [ {type} ].");
        var attribute = (fieldInfo.GetCustomAttributes(typeof(T), false) as T[])?.FirstOrDefault();

        if (attribute == null && defaultValue != null)
            return defaultValue;
        else
            return attribute ?? throw new InvalidOperationException($"Could not find attribute on [ {type} ]");
    }
}