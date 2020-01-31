using System;

namespace TreasureIsland
{
    class ObjectsOnMap
    {
        public static void HomeOnMap()
        {

        }

        public static void RobotOnMap(int X, int Y)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Program.robot);
            Program.frame[X][Y] = Program.robot;
        }

        public static void TreasureOnMap(int X, int Y)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Program.treasure);
            Program.frame[X][Y] = Program.treasure;
        }

        public static void BridgeOnMap(int X, int Y)
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Program.bridge);
            Program.frame[X][Y] = Program.bridge;
        }

        public static void RiverOnMap()
        {
            RangePaint.PathPaint(Program.river, 4, 9, 12, 18);
        }
    }
}
