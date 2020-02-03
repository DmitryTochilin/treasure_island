using System;
using System.Collections.Generic;

namespace TreasureIsland
{
    class Program
    {
        public static List<string[]> frame = new List<string[]>();

        public static string home = "@";
        public static string treasure = "+";
        public static string river = "~";
        public static string bridge = "#";
        public static string emptyCell = ".";
        public static string robot = "%";

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = false;

            MapInit.FrameMaker();

            Helper.Render();

            ObjectsOnMap.RobotOnMap(3, 4);
            ObjectsOnMap.HomeOnMap(3, 5, 9, 10);
            ObjectsOnMap.BridgeOnMap(6, 8);
            ObjectsOnMap.RiverOnMap(9, 7, 3, 18);
            ObjectsOnMap.TreasureOnMap(2, 2);

            Helper.BackCursor();

            FileReader.ReadingFromFile(@"C:\Users\dtochilin\source\repos\TreasureIsland\Map.txt");
            FileReader.BaseParsing();

            Console.ReadKey();
        }
    }
}

