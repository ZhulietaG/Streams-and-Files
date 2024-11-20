internal class Program
{
    private static void Main(string[] args)
    {
        string inputPath = "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Copy File Content\\input.txt";
        string outputPath = "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Copy File Content\\output.txt";

        using(StreamReader reader = new StreamReader(inputPath))
        {
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}