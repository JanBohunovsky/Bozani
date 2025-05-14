using System.Text;
using BozaniBlazor.Common.Extensions;

namespace BozaniBlazor.TextAnalyzers;
internal class NumberTextAnalyzer : ITextAnalyzer
{
    private Dictionary<char, int> numbers = new();

    public void Process(char c)
    {
        if (c.IsNumber())
        {
            numbers.TryAdd(c, 0);
            numbers[c]++;
        }
    }

    public TextAnalysisResult GetResult()
    {
        var stringBuilder = new StringBuilder();
        foreach (var keyValuePair in numbers.OrderBy(a => a.Key))
        {
            stringBuilder.AppendLine($"{keyValuePair.Key}:{keyValuePair.Value}x");
        }

        return new TextAnalysisResult() { Data = stringBuilder.ToString(), Header = "Numbers" };
    }
}
