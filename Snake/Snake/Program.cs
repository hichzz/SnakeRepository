using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            int x = 1;
            Func1(x);
            Console.WriteLine($"Func1 x={x}");

            Func2(x);
            Console.WriteLine($"Func2 x={x}");

            Func3(x);
            Console.WriteLine($"Func3 x={x}");

            Move(p1, 10, 10);
            Console.WriteLine($"Move(p1, 10, 10) p1.x = {p1.X}, p1.y = {p1.Y}");

            Reset(p2, 10, 10);
            Console.WriteLine($"Reset(p2) p2.x = {p2.X}, p2.y = {p2.Y}");

            Console.ReadKey();
        }

        private static void Reset(Point p, int dx, int dy)
        {
            p = new Point();
            p.X = p.X + dx;
            p.Y = p.Y + dy;
        }

        private static void Move(Point p, int dx, int dy)
        {
            p.X = p.X + dx;
            p.Y = p.Y + dy;
        }

        private static void Func3(int x)
        {
            x++;
        }

        private static void Func2(int val)
        {
            val++;
        }

        private static void Func1(int x)
        {

        }

    }
}
