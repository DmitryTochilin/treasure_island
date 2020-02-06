using System;
using System.Collections.Generic;
using static TreasureIsland.Coordinates;
using static TreasureIsland.FileReader;
using static TreasureIsland.Helper;
using static TreasureIsland.ObjectsOnMap;

namespace TreasureIsland
{
    class Program
    {
        public static List<string[]> Frame = new List<string[]>();

        public static string Home = "@";
        public static string Treasure = "+";
        public static string River = "~";
        public static string Bridge = "#";
        public static string Robot = "%";
        public static string Path = "*";

        public static string FilePath = @"C:\Users\dtochilin\Documents\TreasureIsland\Maps\Map.txt";

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = false;

            ReadingFromFile(FilePath);

            MapInit.FrameMaker();

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

        private static void PathPainter()
        {
            PathOnMap(BaseX1,
                      BaseY1,
                      BridgeX,
                      BridgeY);

            PathOnMap(BridgeX,
                      BridgeY,
                      TreasureX,
                      TreasureY);
        }

        private static void RiverPainter()
        {
            RiverOnMap(RiverX1,
                       RiverY1,
                       RiverX2,
                       RiverY2);

            RiverOnMap(RiverX2,
                       RiverY2,
                       RiverX3,
                       RiverY3);

            RiverOnMap(RiverX3,
                       RiverY3,
                       RiverX4,
                       RiverY4);

            RiverOnMap(RiverX4,
                       RiverY4,
                       RiverX5,
                       RiverY5);

            RiverOnMap(RiverX5,
                       RiverY5,
                       RiverX6,
                       RiverY6);
        }
    }
}

