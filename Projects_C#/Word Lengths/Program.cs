using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "E:\\Sirma Academy\\Streams and Files\\Projects\\Word Lengths\\input.txt";

        using (StreamReader text = new StreamReader(filePath))
        {
            string line;
            while ((line = text.ReadLine()) != null)
            {
                string[] words = line.Split(' ');
                foreach (string word in words)
                {
                    Console.Write($"{word.Length} ");
                }
            }
        }

    }
}