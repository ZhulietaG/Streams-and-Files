using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Extract File\\some_file.txt";

        string fileName = Path.GetFileNameWithoutExtension(filePath);
        string fileExtension = Path.GetExtension(filePath);
        long fileSize = new FileInfo(filePath).Length;

        Console.WriteLine("File Name: " + fileName);
        Console.WriteLine("File Extension: " + fileExtension);
        Console.WriteLine("File Size: " + fileSize);
    }
}