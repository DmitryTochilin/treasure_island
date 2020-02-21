using System;
using static TreasureIsland.Coordinates;


namespace TreasureIsland
{
    class MapInit
    {
        public static int Width = MaxX();
        public static int Height = MaxY();
        public static char[,] Map = new char[Width, Height];

        public static void MapMaker()
        {
            int num = 0;


            for (int y = 0; y < Map.GetLength(1); y++)
            {

                for (int x = 0; x < Map.GetLength(0); x++)
                {

                    if (y == Height - 1 && x != 0)
                    {
                        Map[x, y] = '#';
                        Console.Write(Map[x, y]);
                    }
                    else if (x == Width - 1 && y != 0)
                    {
                        Map[x, y] = '#';
                        Console.Write(Map[x, y]);
                    }
                    else if (x == 0)
                    {
                        Map[x, y] = Convert.ToChar(num.ToString());
                        Console.Write(Map[x, y]);
                        num = num + 1;
                        if (num == 10)
                        {
                            num = 0;
                        }
                    }
                    else if (y == 0)
                    {
                        Map[x, y] = Convert.ToChar(num.ToString());
                        Console.Write(Map[x, y]);
                        num = num + 1;
                        if (num == 10)
                        {
                            num = 0;
                        }
                        if (y == 0 && x == Width - 1)
                        {
                            num = 1;
                        }
                    }
                    else
                    {
                        Map[x, y] = '.';
                        Console.Write(Map[x, y]);
                    }
                }
                Console.WriteLine();
            }
        }

    }

}
