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

            HorizontalLine horizontalLine = new HorizontalLine(4, 7, 3, '-');
            horizontalLine.Draw();

            VerticalLine verticalLine = new VerticalLine(2, 2, 6, '|');
            verticalLine.Draw(); 

            Console.ReadLine();
        }

    }
}
