using System.Globalization;
using System.Text;

namespace BozaniBlazor.Common.Extensions;
internal static class StringExtensions
{
    public static string RemoveSpecialCharModifiers(this string input)
    {
        var normalized = input.Normalize(NormalizationForm.FormD);
        var normalizedString = new string(normalized
            .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
            .ToArray());
        return normalizedString.Normalize(NormalizationForm.FormC);
    }
}
