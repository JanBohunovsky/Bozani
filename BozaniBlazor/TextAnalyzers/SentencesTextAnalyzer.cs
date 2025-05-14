using System.Text;

namespace BozaniBlazor.TextAnalyzers;
internal class SentencesTextAnalyzer : ITextAnalyzer
{
    private StringBuilder sentences = new StringBuilder();

    public void Process(char c)
    {
        if (c == '.')
        {
            sentences.AppendLine();
        }
        else
        {
            sentences.Append(c);
        }
    }

    public TextAnalysisResult GetResult()
    {
        return new TextAnalysisResult() { Data = sentences.ToString(), Header = "Sentences" };
    }
}
