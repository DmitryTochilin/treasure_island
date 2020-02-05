﻿using System;

namespace TreasureIsland
{
    class ObjectsOnMap
    {
        public static void HomeOnMap(int x1, int y1, int x2, int y2)
        {

            int defaultY = y2;

            if (x1 > x2)
            {
                while (x1 >= x2)
                {
                    y2 = defaultY;
                    Program.Frame[y2][x2 += 1] = Program.Home;
                    Helper.Render();
                    if (y1 > y2)
                    {
                        while (y1 > y2)
                        {
                            Program.Frame[y2 += 1][x2] = Program.Home;
                            Helper.Render();
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 > y2)
                        {
                            Program.Frame[y2 -= 1][x2] = Program.Home;
                            Helper.Render();
                        }
                    }
                }
            }
            else if (x1 < x2)
            {
                while (x1 <= x2)
                {
                    y2 = defaultY;
                    Program.Frame[y2][x2 -= 1] = Program.Home;
                    Helper.Render();
                    if (y1 > y2)
                    {
                        while (y1 > y2)
                        {
                            Program.Frame[y2 += 1][x2] = Program.Home;
                            Helper.Render();
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 < y2)
                        {
                            Program.Frame[y2 -= 1][x2] = Program.Home;
                            Helper.Render();
                        }
                    }
                }
            }
        }

        public static void RobotOnMap(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Program.Robot);
            Program.Frame[y][x] = Program.Robot;
        }

        public static void TreasureOnMap(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Program.Treasure);
            Program.Frame[y][x] = Program.Treasure;
        }

        public static void BridgeOnMap(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Program.Bridge);
            Program.Frame[y][x] = Program.Bridge;
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
                            Program.Frame[y2][x2] = Program.River;
                            Helper.Render();
                        }
                    }
                    else if (y1 < y2)
                    {
                        while (y1 < y2)
                        {
                            y2 -= 1;
                            Program.Frame[y2][x2] = Program.River;
                            Helper.Render();
                        }
                    }

                    Program.Frame[y2][x2] = Program.River;
                    Helper.Render();
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

                            Program.Frame[y2][x2 += 1] = Program.River;
                            Helper.Render();
                        }
                        else if (y1 < y2)
                        {
                            while (y1 < y2)
                            {
                                y2 -= 1;
                                break;
                            }
                        }

                        Program.Frame[y2][x2 += 1] = Program.River;
                        Helper.Render();
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

                        Program.Frame[y2][x2 -= 1] = Program.River;
                        Helper.Render();
                    }
                }
            }
        }
    }
}
