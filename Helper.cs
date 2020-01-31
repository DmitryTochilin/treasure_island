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
            for (int x = 0; x < Program.frame.Count; x++)
            {
                Console.WriteLine(string.Join("", Program.frame[x]));
            }
        }
    }
}
