

namespace TreasureIsland
{
    class RangePaint
    {
        public static void PathPaint(string obj, int X1, int Y1, int X2, int Y2)
        {
            if (X1 == X2)
            {
                if (Y1 > Y2)
                {
                    while (Y1 > Y2)
                    {
                        Y2 += 1;
                        Program.frame[X2][Y2] = obj;
                        Helper.Render();
                    }
                }
                else if (Y1 < Y2)
                {
                    while (Y1 < Y2)
                    {
                        Y2 -= 1;
                        Program.frame[X2][Y2] = obj;
                        Helper.Render();
                    }
                }

                Program.frame[X2][Y2] = obj;
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

                        Program.frame[X2 += 1][Y2] = obj;
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

                    Program.frame[X2 += 1][Y2] = obj;
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

                    Program.frame[X2 -= 1][Y2] = obj;
                    Helper.Render();
                }
            }
        }
    }
}
