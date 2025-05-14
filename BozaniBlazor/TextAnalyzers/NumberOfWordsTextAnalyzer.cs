namespace BozaniBlazor.TextAnalyzers;
using Common.Extensions;

internal class NumberOfWordsTextAnalyzer : ITextAnalyzer
{
    private readonly int minSize;
    private string currentWord;
    private int count;

    public NumberOfWordsTextAnalyzer(int minSize)
    {
        this.minSize = minSize;
    }

    public void Process(char c)
    {
        if (c.IsLetter())
            currentWord += c;
        else
        {
            if (currentWord.Length >= minSize)
            {
                count++;
                currentWord = "";
            }
            else
            {
                currentWord = "";
            }
        }
    }

    public TextAnalysisResult GetResult()
    {
        return new TextAnalysisResult() { Data = $"{count}", Header = $"Number Of Words (>={minSize})" };
    }
}
