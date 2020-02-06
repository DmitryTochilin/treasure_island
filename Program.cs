using System;
using System.Collections.Generic;

using static TreasureIsland.FileReader;
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

            Helper.Render();

            RobotOnMap(BaseParsing()[0],
                       BaseParsing()[1]);

            RiverPainter();


            TreasureOnMap(TreasureParsing()[0], 
                          TreasureParsing()[1]);

            PathPainter();

            HomeOnMap(BaseParsing()[0],
                      BaseParsing()[1],
                      BaseParsing()[2],
                      BaseParsing()[3]);

            BridgeOnMap(BridgeParsing()[0],
                        BridgeParsing()[1]);


            Helper.BackCursor();


            Console.ReadKey();
        }

        private static void PathPainter()
        {
            PathOnMap(BaseParsing()[0],
                BaseParsing()[1],
                BridgeParsing()[0],
                BridgeParsing()[1]);

            PathOnMap(BridgeParsing()[0],
                BridgeParsing()[1],
                TreasureParsing()[0],
                TreasureParsing()[1]);
        }

        private static void RiverPainter()
        {
            RiverOnMap(RiverParsing()[0],
                    RiverParsing()[1],
                    RiverParsing()[2],
                    RiverParsing()[3]);

            RiverOnMap(RiverParsing()[2],
                    RiverParsing()[3],
                    RiverParsing()[4],
                    RiverParsing()[5]);

            RiverOnMap(RiverParsing()[4],
                    RiverParsing()[5],
                    RiverParsing()[6],
                    RiverParsing()[7]);

            RiverOnMap(RiverParsing()[6],
                    RiverParsing()[7],
                    RiverParsing()[8],
                    RiverParsing()[9]);

            RiverOnMap(RiverParsing()[8],
                    RiverParsing()[9],
                    RiverParsing()[10],
                    RiverParsing()[11]);
        }
    }
}

