using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;

            Draw(x1, y1, '*');

            Console.ReadLine();
        }

        static void Draw(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symbol);
        }
    }
}
