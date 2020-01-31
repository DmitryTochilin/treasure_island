using System;
using System.IO;

namespace TreasureIsland
{
    class FileReader
    {
        static string line;

        public static void ReadingFromFile(string filePath)
        {
            string[] allLines = File.ReadAllLines(filePath);

            line = allLines[0].ToLower();

        }

        public static void BaseParsing()
        {
            if (line.StartsWith("base"))
            {
                line = line.Replace("base", "")
                            .Replace(" ", "")
                            .Replace("(", "")
                            .Replace(")", "");

                string[] coordinates = line.Split(":");

                string[] start = coordinates[0].Split(",");

                string[] end = coordinates[1].Split(",");

                Console.WriteLine(start[0]);
                Console.WriteLine(end[1]);
            }
        } 
    }
}        
