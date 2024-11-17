using System;
using System.IO;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Character Frequency\\input.txt";
        using (StreamReader reader = new StreamReader(filePath))
        {
            string input = reader.ReadToEnd();
            input = Regex.Replace(input, @"\s+", "");
            ////testing the new string without white spaces
            //Console.WriteLine(input);
            List<char> chars = new List<char>(input);
            while (chars.Count > 0)
            {
                char curChar = chars[0];
                int count = 1;
                chars.RemoveAt(0);
                for (int i = 0; i < chars.Count; i++)
                {
                    if (curChar == chars[i])
                    {
                        count++;
                        chars.RemoveAt(i);
                    }
                }
                Console.WriteLine($"{curChar}: {count}");
            }
            
        }

    }
}