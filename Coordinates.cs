using static TreasureIsland.FileReader;

namespace TreasureIsland
{
    class Coordinates
    {
        public static int TreasureX = TreasureParsing()[0];

        public static int TreasureY = TreasureParsing()[1];

        public static int BridgeX = BridgeParsing()[0];

        public static int BridgeY = BridgeParsing()[1];

        public static int BaseX1 = BaseParsing()[0];

        public static int BaseY1 = BaseParsing()[1];

        public static int BaseX2 = BaseParsing()[2];

        public static int BaseY2 = BaseParsing()[3];

        public static int RiverX1 = RiverParsing()[0];

        public static int RiverY1 = RiverParsing()[1];

        public static int RiverX2 = RiverParsing()[2];

        public static int RiverY2 = RiverParsing()[3];

        public static int RiverX3 = RiverParsing()[4];

        public static int RiverY3 = RiverParsing()[5];

        public static int RiverX4 = RiverParsing()[6];

        public static int RiverY4 = RiverParsing()[7];

        public static int RiverX5 = RiverParsing()[8];

        public static int RiverY5 = RiverParsing()[9];

        public static int RiverX6 = RiverParsing()[10];

        public static int RiverY6 = RiverParsing()[11];


        public static int MaxX()
        {
            int[] array = { TreasureX + 4, BridgeX + 4, BaseX1 + 4, BaseX2 + 4, RiverX1, RiverX2, RiverX3, RiverX4, RiverX5, RiverX6 };

            int max = int.MinValue;
            foreach (int x in array)
            {
                if (x >= max)
                {
                    max = x;
                }
            }
            return max;
        }

        public static int MaxY()
        {
            int[] array = { TreasureY + 4, BridgeY + 4, BaseY1 + 4, BaseY2 + 4, RiverY1, RiverY2, RiverY3, RiverY4, RiverY5, RiverY6 };

            int max = int.MinValue;
            foreach (int y in array)
            {
                if (y >= max)
                {
                    max = y;
                }
            }
            return max;
        }
    }
}
