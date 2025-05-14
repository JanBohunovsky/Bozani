using System.Text;
using BozaniBlazor.Common.Extensions;

namespace BozaniBlazor.TextAnalyzers;
internal class NumbersTextAnalyzer : ITextAnalyzer
{
    private StringBuilder result = new StringBuilder();

    public void Process(char c)
    {
        if (c.IsNumber())
            result.Append(c);
    }

    public TextAnalysisResult GetResult()
    {
        return new TextAnalysisResult() { Data = result.ToString(), Header = "Numbers" };
    }
}
