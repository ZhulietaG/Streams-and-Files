using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        string inputPath = "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Replace Word\\input.txt";
        string outputPath = "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Replace Word\\output.txt";
        Console.Write("Original word, which will be replaced: ");
        string oldWord = Console.ReadLine();
        Console.Write("New word for the replacement: ");
        string newWord = Console.ReadLine();
        string outputText;

        using (StreamReader reader = new StreamReader(inputPath))
        {
            string text = reader.ReadToEnd();
            outputText = text.Replace(oldWord, newWord);
            string[] input = reader.ReadToEnd()
                .Split(' ')
                .ToArray();


            File.WriteAllText(outputPath, outputText);
        }
    }
}