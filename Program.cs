using System;
using System.Collections.Generic;
using static TreasureIsland.Coordinates;
using static TreasureIsland.FileReader;
using static TreasureIsland.Helper;
using static TreasureIsland.MapInit;
using static TreasureIsland.ObjectsOnMap;

namespace TreasureIsland
{
    internal class Program
    {
        public static List<string[]> Frame = new List<string[]>();

        public static string Home = "@";
        public static string Treasure = "+";
        public static string River = "~";
        public static string Bridge = "#";
        public static string Robot = "%";
        public static string Path = "*";

        public static string FilePath = @"C:\Users\dtochilin\Documents\TreasureIsland\Maps\Map.txt";

        private static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = false;

            ReadingFromFile(FilePath);

            FrameMaker();

            Render();

            RobotOnMap(BaseX1, BaseY1);

            RiverPainter();

            TreasureOnMap(TreasureX, TreasureY);

            PathPainter();

            BaseOnMap(BaseX1,BaseY1,BaseX2,BaseY2);

            BridgeOnMap(BridgeX, BridgeY);

            BackCursor();

            Console.ReadKey();
        }
    }
}

