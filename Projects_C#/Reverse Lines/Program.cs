using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        string inputPath = "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Reverse Lines\\input.txt";
        string outputPath = "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Reverse Lines\\output.txt";
        int linesCount = File.ReadAllLines(inputPath).Length;
        string[] reversedLines = new string[linesCount];

        using (StreamReader reader = new StreamReader(inputPath))
        {
            for (int i = 0; i < linesCount; i++)
            {
                string line = reader.ReadLine();
                char[] chars = line.ToCharArray();
                Array.Reverse(chars);
                line = new string(chars);
                reversedLines[i] = line;
            }
        }

        using (StreamWriter writer = new StreamWriter(outputPath))
        {
            foreach (string line in reversedLines)
            {
                writer.WriteLine(line);
            }
        }

    }
}

