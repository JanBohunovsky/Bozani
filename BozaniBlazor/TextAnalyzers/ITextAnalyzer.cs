namespace BozaniBlazor.TextAnalyzers;
internal interface ITextAnalyzer
{
    void Process(char c);

    TextAnalysisResult GetResult();
}
