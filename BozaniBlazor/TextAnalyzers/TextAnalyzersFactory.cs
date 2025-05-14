namespace BozaniBlazor.TextAnalyzers;

internal class TextAnalyzersFactory
{
    public ICollection<ITextAnalyzer> Create()
    {
        var analyzers = new List<ITextAnalyzer>
        {
            new CapitalLettersTextAnalyzer(),
            new NumbersTextAnalyzer(),
            new NumberOfSentencesTextAnalyzer(),
            new NumberOfWordsTextAnalyzer(1),
            new NumberOfWordsTextAnalyzer(2),
            new NumberOfWordsTextAnalyzer(3),
            new SentencesTextAnalyzer(),
            new WordsTextAnalyzer(),
            new LetterTextAnalyzer(),
            new NumberTextAnalyzer(),
            new FindWordsTextAnalyzer("jedna"),
            new FindWordsTextAnalyzer("dva"),
            new FindWordsTextAnalyzer("tri"),
            new FindWordsTextAnalyzer("ctyri"),
            new FindWordsTextAnalyzer("pet"),
            new FindWordsTextAnalyzer("sest"),
            new FindWordsTextAnalyzer("sedm"),
            new FindWordsTextAnalyzer("osm"),
            new FindWordsTextAnalyzer("devet")
        };

        return analyzers;
    }
}
