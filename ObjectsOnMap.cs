using System;

namespace TreasureIsland
{
    class ObjectsOnMap
    {
        public static void HomeOnMap(int X1, int Y1, int X2, int Y2)
        {

            int default_Y = Y2;

            if (X1 > X2)
            {
                while (X1 >= X2)
                {
                    Y2 = default_Y;
                    Program.frame[X2 += 1][Y2] = Program.home;
                    Helper.Render();
                    if (Y1 > Y2)
                    {
                        while (Y1 > Y2)
                        {
                            Program.frame[X2][Y2 += 1] = Program.home;
                            Helper.Render();
                        }
                    }
                    else if (Y1 < Y2)
                    {
                        while (Y1 > Y2)
                        {
                            Program.frame[X2][Y2 -= 1] = Program.home;
                            Helper.Render();
                        }
                    }
                }
            }
            else if (X1 < X2)
            {
                while (X1 <= X2)
                {
                    Y2 = default_Y;
                    Program.frame[X2 -= 1][Y2] = Program.home;
                    Helper.Render();
                    if (Y1 > Y2)
                    {
                        while (Y1 > Y2)
                        {
                            Program.frame[X2][Y2 += 1] = Program.home;
                            Helper.Render();
                        }
                    }
                    else if (Y1 < Y2)
                    {
                        while (Y1 < Y2)
                        {
                            Program.frame[X2][Y2 -= 1] = Program.home;
                            Helper.Render();
                        }
                    }
                }
            }
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

        public static void RiverOnMap(int X1, int Y1, int X2, int Y2)
        {
            {
                if (X1 == X2)
                {
                    if (Y1 > Y2)
                    {
                        while (Y1 > Y2)
                        {
                            Y2 += 1;
                            Program.frame[X2][Y2] = Program.river;
                            Helper.Render();
                        }
                    }
                    else if (Y1 < Y2)
                    {
                        while (Y1 < Y2)
                        {
                            Y2 -= 1;
                            Program.frame[X2][Y2] = Program.river;
                            Helper.Render();
                        }
                    }

                    Program.frame[X2][Y2] = Program.river;
                    Helper.Render();
                }

                if (X1 > X2)
                {
                    while (X1 > X2)
                    {
                        if (Y1 > Y2)
                        {
                            while (Y1 > Y2)
                            {
                                Y2 += 1;
                                break;
                            }

                            Program.frame[X2 += 1][Y2] = Program.river;
                            Helper.Render();
                        }
                        else if (Y1 < Y2)
                        {
                            while (Y1 < Y2)
                            {
                                Y2 -= 1;
                                break;
                            }
                        }

                        Program.frame[X2 += 1][Y2] = Program.river;
                        Helper.Render();
                    }
                }

                if (X1 < X2)
                {
                    while (X1 < X2)
                    {
                        if (Y1 > Y2)
                        {
                            while (Y1 > Y2)
                            {
                                Y2 += 1;
                                break;
                            }
                        }
                        else if (Y1 < Y2)
                        {
                            while (Y1 < Y2)
                            {
                                Y2 -= 1;
                                break;
                            }
                        }

                        Program.frame[X2 -= 1][Y2] = Program.river;
                        Helper.Render();
                    }
                }
            }
        }
    }
}
