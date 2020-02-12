using System;
using static TreasureIsland.FileReader;

namespace TreasureIsland
{
    class Helper
    {
        public static void BackCursor()
        {
            Console.SetCursorPosition(0, 21);
            Console.CursorVisible = true;
        }

        public static void Render(int x, int y, char obj)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(obj);
        }

        public static void RiverPainter()
        {
            var indexOfStartX = 0;
            var indexOfStartY = 1;
            var indexOfEndX = 2;
            var indexOfEndY = 3;

            for (var i = 0; i < 5; i++)
            {
                ObjectsOnMap.RiverOnMap(RiverParsing()[indexOfStartX],
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
