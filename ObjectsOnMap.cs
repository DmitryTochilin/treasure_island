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
                    x2 += 1;
                    Render(x2, y2, Home);
                    if (y1 > y2)
                    {
                        while (y1 > y2)
                        {
                            y2 += 1;
                            Render(x2, y2, Home);
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 > y2)
                        {
                            y2 -= 1;
                            Render(x2, y2, Home);
                        }
                    }
                }
            }
            else if (x1 < x2)
            {
                while (x1 <= x2)
                {
                    y2 = defaultY;
                    x2 -= 1;
                    Render(x2, y2, Home);
                    if (y1 > y2)
                    {
                        while (y1 > y2)
                        {
                            y2 += 1;
                            Render(x2, y2, Home);
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 < y2)
                        {
                            y2 -= 1;
                            Render(x2, y2, Home);
                        }
                    }
                }
            }
        }

        public static void RobotOnMap(int x, int y)
        {
            Render(x, y, Robot);
        }

        public static void TreasureOnMap(int x, int y)
        {
            Render(x, y, Treasure);
        }

        public static void BridgeOnMap(int x, int y)
        {
            Render(x, y, Bridge);
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
                            Render(x2, y2, Path);
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 < y2)
                        {
                            y2 -= 1;
                            Render(x2, y2, Path);
                        }
                    }

                    Render(x2, y2, Path);
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

                            x2 += 1;
                            Render(x2, y2, Path);
                        }
                        else if (y1 < y2)
                        {
                            while (y1 < y2)
                            {
                                y2 -= 1;
                                break;
                            }
                        }

                        x2 += 1;
                        Render(x2, y2, Path);
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

                        x2 -= 1;
                        Render(x2, y2, Path);
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
                            Render(x2, y2, River);
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 < y2)
                        {
                            y2 -= 1;
                            Render(x2, y2, River);
                        }
                    }

                    Render(x2, y2, River);
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

                            x2 += 1;
                            Render(x2, y2, River);
                        }
                        else if (y1 < y2)
                        {
                            while (y1 < y2)
                            {
                                y2 -= 1;
                                break;
                            }
                        }

                        x2 += 1;
                        Render(x2, y2, River);
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

                        x2 -= 1;
                        Render(x2, y2, River);
                    }
                }
            }
        }
    }
}
