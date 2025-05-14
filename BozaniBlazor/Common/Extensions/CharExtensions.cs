namespace BozaniBlazor.Common.Extensions;
internal static class CharExtensions
{
    public static bool IsLetter(this char c)
    {
        return IsUpperLetter(c) || IsLowerLetter(c);
    }

    public static bool IsUpperLetter(this char c)
    {
        return (c >= 'A' && c <= 'Z');
    }

    public static bool IsLowerLetter(this char c)
    {
        return (c >= 'a' && c <= 'z');
    }

    public static bool IsNumber(this char c)
    {
        return c >= '0' && c <= '9';
    }
}
