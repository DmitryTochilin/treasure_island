using System;

namespace TreasureIsland
{
    class Helper
    {
        public static void BackCursor()
        {
            Console.SetCursorPosition(0, 21);
            Console.CursorVisible = true;
        }

        public static void Render()
        {
            Console.Clear();
            foreach (var x in Program.Frame)
            {
                Console.WriteLine(string.Join("", x));
            }
        }
    }
}
