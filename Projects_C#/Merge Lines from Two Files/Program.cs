using System;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        string firstInPath= "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Merge Lines from Two Files\\input.txt";
        string secondInPath = "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Merge Lines from Two Files\\input2.txt";
        string outPath = "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Merge Lines from Two Files\\output.txt";

        using (StreamWriter output = new StreamWriter(outPath))
        {
            using (StreamReader firstReader = new StreamReader(firstInPath))
            {
                string firstLine = firstReader.ReadLine();
                using (StreamReader secondReader = new StreamReader(secondInPath))
                {
                    string secondLine = secondReader.ReadLine();

                    while (firstLine != null || secondLine != null)
                    {
                        if (firstLine != null)
                        {
                            output.WriteLine(firstLine);
                        }
                        if (secondLine != null)
                        {
                            output.WriteLine(secondLine);
                        }
                        firstLine = firstReader.ReadLine();
                        secondLine = secondReader.ReadLine();
                    }

                }
            }
        }
    }
}