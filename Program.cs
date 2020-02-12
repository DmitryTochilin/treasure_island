using System;
using static TreasureIsland.Coordinates;
using static TreasureIsland.FileReader;
using static TreasureIsland.Helper;
using static TreasureIsland.MapInit;
using static TreasureIsland.ObjectsOnMap;

namespace TreasureIsland
{
    internal class Program
    {
        public static char Home = '@';
        public static char Treasure = '+';
        public static char River = '~';
        public static char Bridge = '#';
        public static char Robot = '%';
        public static char Path = '*';

        public static string FilePath = @"C:\Users\dtochilin\Documents\TreasureIsland\Maps\Map.txt";

        private static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorVisible = false;

            ReadingFromFile(FilePath);

            MapMaker();

            RobotOnMap(BaseX1, BaseY1);

            RiverPainter();

            TreasureOnMap(TreasureX, TreasureY);

            BaseOnMap(BaseX1,BaseY1,BaseX2,BaseY2);

            BridgeOnMap(BridgeX, BridgeY);

            BackCursor();

            Console.ReadKey();
        }
    }
}

