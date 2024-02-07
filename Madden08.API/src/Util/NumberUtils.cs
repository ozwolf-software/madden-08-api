namespace Madden08.API.Util;

internal static class NumberUtils
{
    internal static int InRange(int lower, int value, int upper)
    {
        if (lower > value) return lower;
        return upper < value ? upper : value;
    }
}