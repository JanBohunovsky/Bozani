using System.Text;
using BozaniBlazor.Common.Extensions;

namespace BozaniBlazor.TextAnalyzers;
internal class CapitalLettersTextAnalyzer : ITextAnalyzer
{
    private StringBuilder result = new StringBuilder();

    public void Process(char c)
    {
        if (c.IsUpperLetter())
            result.Append(c);
    }

    public TextAnalysisResult GetResult()
    {
        return new TextAnalysisResult() { Data = result.ToString(), Header = "Capital Letters" };
    }
}
