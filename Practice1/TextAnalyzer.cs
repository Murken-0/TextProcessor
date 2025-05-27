using System;
using System.Linq;

namespace TextFileProcessor;

public class TextAnalyzer
{
    public int CountTotalWords(string text)
    {
        return text.Split(new[] { ' ', '\n', '\r', '\t', ',', '.', '!', '(', ')' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }

    public int CountWordOccurrences(string text, string searchWord)
    {
        return text.Split(new[] { ' ', '\n', '\r', '\t', ',', '.', '!', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                   .Count(word => word.Equals(searchWord, StringComparison.OrdinalIgnoreCase));
    }
}