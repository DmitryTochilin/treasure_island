using System.IO;

namespace TreasureIsland
{
    class FileReader
    {
        private static string line;

        public static string[] ReadingFromFile(string filePath)
        {
            var allLines = File.ReadAllLines(filePath);

            line = allLines[0].ToLower();

            return allLines;
        }

        public static int[] BaseParsing()
        {
            line = ReadingFromFile(Program.FilePath)[0].ToLower();


            line = line.Replace("base", "")
                       .Replace(" ", "")
                       .Replace("(", "")
                       .Replace(")", "");

            var coordinates = line.Split(":");

            var startPoint = coordinates[0].Split(",");

            var endPoint = coordinates[1].Split(",");



            var x1 = int.Parse(startPoint[0]);
            var y1 = int.Parse(startPoint[1]);

            var x2 = int.Parse(endPoint[0]);
            var y2 = int.Parse(endPoint[1]);

            var test = new int[]{x1, y1, x2, y2};

            return test;
        }

        public static int[] BridgeParsing()
        {
            line = ReadingFromFile(Program.FilePath)[1].ToLower();

            line = line.Replace("bridge", "")
                .Replace(" ", "")
                .Replace("(", "")
                .Replace(")", "");

            var coordinates = line.Split(",");

            var x = int.Parse(coordinates[0]);
            var y = int.Parse(coordinates[1]);


            var test = new int[] { x, y };

            return test;
        }

        public static int[] TreasureParsing()
        {
            line = ReadingFromFile(Program.FilePath)[2].ToLower();

            line = line.Replace("treasure", "")
                .Replace(" ", "")
                .Replace("(", "")
                .Replace(")", "");

            var coordinates = line.Split(",");

            var x = int.Parse(coordinates[0]);
            var y = int.Parse(coordinates[1]);


            var test = new int[] { x, y };

            return test;
        }

        public static int[] RiverParsing()
        {
            line = ReadingFromFile(Program.FilePath)[3].ToLower();

            line = line.Replace("water", "")
                .Replace(" ", "")
                .Replace("(", "")
                .Replace(")", "");

            var coordinates = line.Split("->");

            var firstPoint = coordinates[0].Split(",");
            var secondPoint = coordinates[1].Split(",");
            var thirdPoint = coordinates[2].Split(",");
            var fourthPoint = coordinates[3].Split(",");
            var fifthPoint = coordinates[4].Split(",");
            var sixthPoint = coordinates[5].Split(",");

            var x1 = int.Parse(firstPoint[0]);
            var y1 = int.Parse(firstPoint[1]);

            var x2 = int.Parse(secondPoint[0]);
            var y2 = int.Parse(secondPoint[1]);

            var x3 = int.Parse(thirdPoint[0]);
            var y3 = int.Parse(thirdPoint[1]);

            var x4 = int.Parse(fourthPoint[0]);
            var y4 = int.Parse(fourthPoint[1]);

            var x5 = int.Parse(fifthPoint[0]);
            var y5 = int.Parse(fifthPoint[1]);

            var x6 = int.Parse(sixthPoint[0]);
            var y6 = int.Parse(sixthPoint[1]);


            var test = new int[] { x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6 };

            return test;
        }


    }
}
        
