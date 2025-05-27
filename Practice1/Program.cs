using System;

namespace TextFileProcessor;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("How to use: Practice1 <file_path> <word_to_search>");
            return;
        }

        string filePath = args[0];
        string searchWord = args[1];

        try
        {
            var processor = new TextProcessor();
            processor.ProcessFile(filePath, searchWord);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}