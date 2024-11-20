internal class Program
{
    private static void Main(string[] args)
    {
        string dirPath = "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Calculate Directory Size\\TestDir";
        long totalSize = FolderSize(dirPath);
        Console.WriteLine($"Total size: {totalSize} bytes.");

    }

    public static long FolderSize(string path)
    {
        long size = 0;
        string[] files = Directory.GetFiles(path);
        foreach (string file in files)
        {
            FileInfo fileInfo = new FileInfo(file);
            size += fileInfo.Length;
        }

        string[] dirs = Directory.GetDirectories(path);
        foreach (string dir in dirs)
        {
            size += FolderSize(dir);
        }

        return size;
    }
}