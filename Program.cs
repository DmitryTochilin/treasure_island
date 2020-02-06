using System;
using System.Collections.Generic;
using static TreasureIsland.Coordinates;
using static TreasureIsland.FileReader;
using static TreasureIsland.Helper;
using static TreasureIsland.MapInit;
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
            int indexOfStartX = 0;
            int indexOfStartY = 1;
            int indexOfEndX = 2;
            int indexOfEndY = 3;

            for (int i = 0; i < 5; i++)
            {
                RiverOnMap(RiverParsing()[indexOfStartX], 
                           RiverParsing()[indexOfStartY], 
                           RiverParsing()[indexOfEndX], 
                           RiverParsing()[indexOfEndY]);

                indexOfStartX += 2;
                indexOfStartY += 2;
                indexOfEndX += 2;
                indexOfEndY += 2;
            }
        }
    }
}

