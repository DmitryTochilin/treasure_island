using static TreasureIsland.FileReader;

namespace TreasureIsland
{
    class Coordinates
    {
        public static int TreasureX => TreasureParsing()[0];

        public static int TreasureY => TreasureParsing()[1];

        public static int BridgeX => BridgeParsing()[0];

        public static int BridgeY => BridgeParsing()[1];

        public static int BaseX1 => BaseParsing()[0];

        public static int BaseY1 => BaseParsing()[1];

        public static int BaseX2 => BaseParsing()[2];

        public static int BaseY2 => BaseParsing()[3];
    }
}
