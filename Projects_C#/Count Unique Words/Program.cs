using System.Runtime.InteropServices.Marshalling;

internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Count Unique Words\\input.txt";

        int result = 0;
        HashSet<string> unique = new HashSet<string>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line
                .Split(new char[] { ' ', '\t', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    if (unique.Contains(word) == false)
                    {
                        unique.Add(word);
                    }
                }
            }          
            result = unique.Count();
        }

        Console.WriteLine("Unique words: " + result);
    }
}