using System.Text;
using BozaniBlazor.Common.Extensions;

namespace BozaniBlazor.TextAnalyzers;
internal class WordsTextAnalyzer : ITextAnalyzer
{
    private Dictionary<string, int> words = new();
    private string currentWord = "";

    public void Process(char c)
    {
        if (c.IsLetter())
        {
            currentWord += c;
        }
        else
        {
            if (currentWord.Length > 0)
            {
                words.TryAdd(currentWord, 0);
                words[currentWord]++;
                currentWord = "";
            }
        }
    }

    public TextAnalysisResult GetResult()
    {
        var stringBuilder = new StringBuilder();
        foreach (var keyValuePair in words.OrderBy(a => a.Key))
        {
            stringBuilder.AppendLine($"{keyValuePair.Key}:{keyValuePair.Value}x");
        }
        return new TextAnalysisResult() { Data = stringBuilder.ToString(), Header = "Words" };
    }
}
