using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        string filePath = "E:\\Sirma Academy\\Streams and Files\\Projects_C#\\Serialize and Deserialize Map\\map.dat";

        Dictionary<string, int> map = new Dictionary<string, int>()
        {
            {"Test1", 1 },
            {"Test2", 2 },
            {"Test3", 3 }
        };
        Dictionary<string, int> newMap = new Dictionary<string, int>();

        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            //integer for key-value pairs, stored in the file
            writer.Write(map.Count);
            foreach (var kvp in map)
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(kvp.Key);
                writer.Write(keyBytes.Length); //integer for total bytes in a key
                writer.Write(keyBytes);
                writer.Write(kvp.Value);
            }
        }

        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            int kvpCount = reader.ReadInt32();
            for (int i = 0; i < kvpCount; i++)
            {
                int keyLength = reader.ReadInt32();
                byte[] keyBytes = reader.ReadBytes(keyLength);
                string key = Encoding.UTF8.GetString(keyBytes);
                int value = reader.ReadInt32();
                newMap[key] = value;
            }
        }

        foreach (var kvp in newMap)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}