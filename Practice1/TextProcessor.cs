namespace TextFileProcessor;

public class TextProcessor
{
    private readonly TextAnalyzer _textAnalyzer;

    public TextProcessor()
    {
        _textAnalyzer = new TextAnalyzer();
    }

    public void ProcessFile(string filePath, string searchWord)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException("File not found.");

        string text = File.ReadAllText(filePath);

        int totalWords = _textAnalyzer.CountTotalWords(text);
        int wordCount = _textAnalyzer.CountWordOccurrences(text, searchWord);

        Console.WriteLine($"Total words in file: {totalWords}");
        Console.WriteLine($"Count of '{searchWord}': {wordCount}");
    }
}