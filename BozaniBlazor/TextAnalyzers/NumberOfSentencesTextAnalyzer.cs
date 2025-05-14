namespace BozaniBlazor.TextAnalyzers;
internal class NumberOfSentencesTextAnalyzer : ITextAnalyzer
{
    private int count;

    public void Process(char c)
    {
        if (c == '.')
            count++;
    }

    public TextAnalysisResult GetResult()
    {
        return new TextAnalysisResult() { Data = $"{count}", Header = "Number Of Sentences" };
    }
}
