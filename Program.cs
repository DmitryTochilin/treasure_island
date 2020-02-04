using System;
using System.Collections.Generic;

namespace TreasureIsland
{
    class Program
    {
        public static List<string[]> Frame = new List<string[]>();

        public static string Home = "@";
        public static string Treasure = "+";
        public static string River = "~";
        public static string Bridge = "#";
        public static string EmptyCell = ".";
        public static string Robot = "%";

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = false;

            FileReader.ReadingFromFile(@"C:\Users\dtochilin\source\repos\TreasureIsland\Map.txt");

            MapInit.FrameMaker();

            Helper.Render();


            ObjectsOnMap.RobotOnMap(3, 4);
            ObjectsOnMap.HomeOnMap(FileReader.BaseParsing()[0],
                                   FileReader.BaseParsing()[1],
                                   FileReader.BaseParsing()[2],
                                   FileReader.BaseParsing()[3]);
            ObjectsOnMap.BridgeOnMap(6, 8);
            ObjectsOnMap.RiverOnMap(4, 2, 7, 5);
            ObjectsOnMap.TreasureOnMap(2, 2);


            Helper.BackCursor();

            Console.ReadKey();
        }
    }
}

