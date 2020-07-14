using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.X = 1;
            p1.Y = 3;
            p1.Symbol = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.X = 4;
            p2.Y = 5;
            p2.Symbol = '#';
            p2.Draw();

            Console.ReadLine();
        }

    }
}
