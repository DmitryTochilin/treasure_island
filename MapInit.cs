using System;

namespace TreasureIsland
{
    class MapInit
    {
        const int Width = 40;
        const int Height = 20;
        public static char[,] Map = new char[Width, Height];

        public static void MapMaker()
        {
            int num = 0;


            for (int h = 0; h < Map.GetLength(1); h++)
            {

                for (int w = 0; w < Map.GetLength(0); w++)
                {

                    if (h == Height - 1 && w != 0)
                    {
                        Map[w, h] = '#';
                        Console.Write(Map[w, h]);
                    }
                    else if (w == Width - 1 && h != 0)
                    {
                        Map[w, h] = '#';
                        Console.Write(Map[w, h]);
                    }
                    else if (w == 0)
                    {
                        Map[w, h] = Convert.ToChar(num.ToString());
                        Console.Write(Map[w, h]);
                        num = num + 1;
                        if (num == 10)
                        {
                            num = 0;
                        }
                    }
                    else if (h == 0)
                    {
                        Map[w, h] = Convert.ToChar(num.ToString());
                        Console.Write(Map[w, h]);
                        num = num + 1;
                        if (num == 10)
                        {
                            num = 0;
                        }
                        if (h == 0 && w == 39)
                        {
                            num = 1;
                        }
                    }
                    else
                    {
                        Map[w, h] = '.';
                        Console.Write(Map[w, h]);
                    }
                }
                Console.WriteLine();
            }
        }

    }

}
