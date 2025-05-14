using System.Text;
using BozaniBlazor.Common.Extensions;

namespace BozaniBlazor.TextAnalyzers;
internal class LetterTextAnalyzer : ITextAnalyzer
{
    private Dictionary<char, int> letters = new();

    public void Process(char c)
    {
        var toLower = char.ToLower(c);
        if (toLower.IsLetter())
        {
            letters.TryAdd(toLower, 0);
            letters[toLower]++;
        }
    }

    public TextAnalysisResult GetResult()
    {
        var stringBuilder = new StringBuilder();
        foreach (var keyValuePair in letters.OrderBy(a => a.Key))
        {
            stringBuilder.AppendLine($"{keyValuePair.Key}:{keyValuePair.Value}x");
        }

        return new TextAnalysisResult() { Data = stringBuilder.ToString(), Header = "Letters" };
    }
}
