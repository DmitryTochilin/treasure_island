using System;
using static TreasureIsland.Helper;
using static TreasureIsland.Program;

namespace TreasureIsland
{
    class ObjectsOnMap
    {
        public static void BaseOnMap(int x1, int y1, int x2, int y2)
        {

            int defaultY = y2;

            if (x1 > x2)
            {
                while (x1 >= x2)
                {
                    y2 = defaultY;
                    Console.SetCursorPosition(x2 += 1, y2);
                    Console.Write(Home);
                    if (y1 > y2)
                    {
                        while (y1 > y2)
                        {
                            Console.SetCursorPosition(x2, y2 += 1);
                            Console.Write(Home);
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 > y2)
                        {
                            Console.SetCursorPosition(x2, y2 -= 1);
                            Console.Write(Home);
                        }
                    }
                }
            }
            else if (x1 < x2)
            {
                while (x1 <= x2)
                {
                    y2 = defaultY;
                    Console.SetCursorPosition(x2 -= 1,y2);
                    Console.Write(Home);
                    if (y1 > y2)
                    {
                        while (y1 > y2)
                        {
                            Console.SetCursorPosition(x2, y2 += 1);
                            Console.Write(Home);
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 < y2)
                        {
                            Console.SetCursorPosition(x2, y2 -= 1);
                            Console.Write(Home);
                        }
                    }
                }
            }
        }

        public static void RobotOnMap(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Robot);
        }

        public static void TreasureOnMap(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Treasure);
        }

        public static void BridgeOnMap(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Bridge);
        }

        public static void PathOnMap(int x1, int y1, int x2, int y2)
        {
            {
                if (x1 == x2)
                {
                    if (y1 > y2)
                    {
                        while (y1 > y2)
                        {
                            y2 += 1;
                            Console.SetCursorPosition(x2, y2);
                            Console.Write(Path);
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 < y2)
                        {
                            y2 -= 1;
                            Console.SetCursorPosition(x2, y2);
                            Console.Write(Path);
                        }
                    }

                    Console.SetCursorPosition(x2, y2);
                    Console.Write(Path);
                }

                if (x1 > x2)
                {
                    while (x1 > x2)
                    {
                        if (y1 > y2)
                        {
                            while (y1 > y2)
                            {
                                y2 += 1;
                                break;
                            }

                            Console.SetCursorPosition(x2 += 1,y2);
                            Console.Write(Path);
                        }
                        else if (y1 < y2)
                        {
                            while (y1 < y2)
                            {
                                y2 -= 1;
                                break;
                            }
                        }

                        Console.SetCursorPosition(x2 += 1, y2);
                        Console.Write(Path);
                    }
                }

                if (x1 < x2)
                {
                    while (x1 < x2)
                    {
                        if (y1 > y2)
                        {
                            while (y1 > y2)
                            {
                                y2 += 1;
                                break;
                            }
                        }
                        else if (y1 < y2)
                        {
                            while (y1 < y2)
                            {
                                y2 -= 1;
                                break;
                            }
                        }

                        Console.SetCursorPosition(x2 -= 1, y2);
                        Console.Write(Path);
                    }
                }
            }
        }

        public static void RiverOnMap(int x1, int y1, int x2, int y2)
        {
            {
                if (x1 == x2)
                {
                    if (y1 > y2)
                    {
                        while (y1 > y2)
                        {
                            y2 += 1;
                            Console.SetCursorPosition(x2, y2);
                            Console.Write(River);
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 < y2)
                        {
                            y2 -= 1;
                            Console.SetCursorPosition(x2, y2);
                            Console.Write(River);
                        }
                    }

                    Console.SetCursorPosition(x2,y2);
                    Console.Write(River);
                }

                if (x1 > x2)
                {
                    while (x1 > x2)
                    {
                        if (y1 > y2)
                        {
                            while (y1 > y2)
                            {
                                y2 += 1;
                                break;
                            }

                            Console.SetCursorPosition(x2 += 1, y2);
                            Console.Write(River);
                        }
                        else if (y1 < y2)
                        {
                            while (y1 < y2)
                            {
                                y2 -= 1;
                                break;
                            }
                        }

                        Console.SetCursorPosition(x2 += 1,y2);
                        Console.Write(River);
                    }
                }

                if (x1 < x2)
                {
                    while (x1 < x2)
                    {
                        if (y1 > y2)
                        {
                            while (y1 > y2)
                            {
                                y2 += 1;
                                break;
                            }
                        }
                        else if (y1 < y2)
                        {
                            while (y1 < y2)
                            {
                                y2 -= 1;
                                break;
                            }
                        }

                        Console.SetCursorPosition(x2 -= 1,y2);
                        Console.Write(River);
                    }
                }
            }
        }
    }
}
