namespace BozaniBlazor.TextAnalyzers;
using Common.Extensions;
internal class FindWordsTextAnalyzer : ITextAnalyzer
{
    private string findWord;
    private List<string> currentWords = new();
    private int count;

    public FindWordsTextAnalyzer(string word)
    {
        findWord = word;
    }

    public void Process(char c)
    {
        var toLower = char.ToLower(c);
        if (toLower.IsLetter())
        {
            currentWords = currentWords.Select(x => x + toLower).ToList();
            currentWords.Add($"{toLower}");
            foreach (var word in currentWords.ToList())
            {
                if (findWord.Equals(word))
                {
                    count++;
                    currentWords.Remove(word);
                }
                else if (!findWord.Contains(word))
                {
                    currentWords.Remove(word);
                }
            }
        }
    }

    public TextAnalysisResult GetResult()
    {
        return new TextAnalysisResult() { Data = $"{count}x", Header = $"Occurence of {findWord}" };
    }
}
