namespace Madden08.API.Util
{
    internal static class StringExtensions
    {
        public static bool EqualsIgnoreCase(this string first, string second) => string.Equals(first, second, StringComparison.OrdinalIgnoreCase);
    }
}
