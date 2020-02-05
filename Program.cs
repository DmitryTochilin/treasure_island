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
        public static string Robot = "%";
        public static string Path = "*";

        public static string FilePath = @"C:\Users\dtochilin\Documents\TreasureIsland\Maps\Map.txt";

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = false;

            FileReader.ReadingFromFile(FilePath);

            MapInit.FrameMaker();

            Helper.Render();


            ObjectsOnMap.HomeOnMap(FileReader.BaseParsing()[0],
                                   FileReader.BaseParsing()[1],
                                   FileReader.BaseParsing()[2],
                                   FileReader.BaseParsing()[3]);

            ObjectsOnMap.RobotOnMap(FileReader.BaseParsing()[2],
                                    FileReader.BaseParsing()[3]);



            ObjectsOnMap.RiverOnMap(FileReader.RiverParsing()[0],
                                    FileReader.RiverParsing()[1],

                                    FileReader.RiverParsing()[2],
                                    FileReader.RiverParsing()[3]);

            ObjectsOnMap.RiverOnMap(FileReader.RiverParsing()[2],
                                    FileReader.RiverParsing()[3],

                                    FileReader.RiverParsing()[4],
                                    FileReader.RiverParsing()[5]);

            ObjectsOnMap.RiverOnMap(FileReader.RiverParsing()[4],
                                    FileReader.RiverParsing()[5],

                                    FileReader.RiverParsing()[6],
                                    FileReader.RiverParsing()[7]);

            ObjectsOnMap.RiverOnMap(FileReader.RiverParsing()[6],
                                    FileReader.RiverParsing()[7],

                                    FileReader.RiverParsing()[8],
                                    FileReader.RiverParsing()[9]);

            ObjectsOnMap.RiverOnMap(FileReader.RiverParsing()[8],
                                    FileReader.RiverParsing()[9],

                                    FileReader.RiverParsing()[10],
                                    FileReader.RiverParsing()[11]);


            ObjectsOnMap.BridgeOnMap(FileReader.BridgeParsing()[0],
                                     FileReader.BridgeParsing()[1]);

            ObjectsOnMap.TreasureOnMap(FileReader.TreasureParsing()[0],
                                       FileReader.TreasureParsing()[1]);

            ObjectsOnMap.PathOnMap(FileReader.BaseParsing()[2], 
                                   FileReader.BaseParsing()[3], 
                                   FileReader.BridgeParsing()[0], 
                                   FileReader.BridgeParsing()[1]);

            ObjectsOnMap.PathOnMap(FileReader.BridgeParsing()[0],
                                   FileReader.BridgeParsing()[1],
                                   FileReader.TreasureParsing()[0],
                                   FileReader.TreasureParsing()[1]);


            Helper.BackCursor();


            Console.ReadKey();
        }
    }
}

