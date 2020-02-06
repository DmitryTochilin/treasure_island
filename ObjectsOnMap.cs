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
                    Frame[y2][x2 += 1] = Home;
                    Render();
                    if (y1 > y2)
                    {
                        while (y1 > y2)
                        {
                            Frame[y2 += 1][x2] = Home;
                            Render();
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 > y2)
                        {
                            Frame[y2 -= 1][x2] = Home;
                            Render();
                        }
                    }
                }
            }
            else if (x1 < x2)
            {
                while (x1 <= x2)
                {
                    y2 = defaultY;
                    Frame[y2][x2 -= 1] = Home;
                    Render();
                    if (y1 > y2)
                    {
                        while (y1 > y2)
                        {
                            Frame[y2 += 1][x2] = Home;
                            Render();
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 < y2)
                        {
                            Frame[y2 -= 1][x2] = Home;
                            Render();
                        }
                    }
                }
            }
        }

        public static void RobotOnMap(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Robot);
            Frame[y][x] = Robot;
        }

        public static void TreasureOnMap(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Treasure);
            Frame[y][x] = Treasure;
        }

        public static void BridgeOnMap(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Bridge);
            Frame[y][x] = Bridge;
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
                            Frame[y2][x2] = Path;
                            Render();
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 < y2)
                        {
                            y2 -= 1;
                            Frame[y2][x2] = Path;
                            Render();
                        }
                    }

                    Frame[y2][x2] = Path;
                    Render();
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

                            Frame[y2][x2 += 1] = Path;
                            Render();
                        }
                        else if (y1 < y2)
                        {
                            while (y1 < y2)
                            {
                                y2 -= 1;
                                break;
                            }
                        }

                        Frame[y2][x2 += 1] = Path;
                        Render();
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

                        Frame[y2][x2 -= 1] = Path;
                        Render();
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
                            Frame[y2][x2] = River;
                            Render();
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 < y2)
                        {
                            y2 -= 1;
                            Frame[y2][x2] = River;
                            Render();
                        }
                    }

                    Frame[y2][x2] = River;
                    Render();
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

                            Frame[y2][x2 += 1] = River;
                            Render();
                        }
                        else if (y1 < y2)
                        {
                            while (y1 < y2)
                            {
                                y2 -= 1;
                                break;
                            }
                        }

                        Frame[y2][x2 += 1] = River;
                        Render();
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

                        Frame[y2][x2 -= 1] = River;
                        Render();
                    }
                }
            }
        }
    }
}
