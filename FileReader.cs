using System;
using System.IO;

namespace TreasureIsland
{
    class FileReader
    {
        private static string line;

        public static void ReadingFromFile(string filePath)
        {
            var allLines = File.ReadAllLines(filePath);

            line = allLines[0].ToLower();

        }

        public static int[] BaseParsing()
        {

            line = line.Replace("base", "")
                       .Replace(" ", "")
                       .Replace("(", "")
                       .Replace(")", "");

            var coordinates = line.Split(":");

            var startPoint = coordinates[0].Split(",");

            var endPoint = coordinates[1].Split(",");



            var X1 = int.Parse(startPoint[0]);
            var Y1 = int.Parse(startPoint[1]);

            var X2 = int.Parse(endPoint[0]);
            var Y2 = int.Parse(endPoint[1]);

            var test = new int[]{X1, Y1, X2, Y2};

            return test;
        }
    }
}
        
