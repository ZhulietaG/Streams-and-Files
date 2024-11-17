using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Count Lines, Words, and Characters\\input.txt";

        string[] lines = File.ReadAllLines(filePath);
        int linesCount = lines.Length;
        int wordsCount = 0;
        int charsCount = 0;

        foreach (string line in lines)
        {
            string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (string word in words)
            {
                wordsCount++;
            }
            charsCount += line.Length;
        }
        Console.WriteLine($"Number of lines: {linesCount}");
        Console.WriteLine($"Number of words: {wordsCount}");
        Console.WriteLine($"Number of characters: {charsCount}");
    }
}