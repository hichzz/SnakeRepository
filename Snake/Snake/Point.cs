using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int X;
        public int Y;
        public char Symbol;
        
        public Point()
        {

        }

        public Point(int x, int y, char symbol)
        {
            X = x;
            Y = y;
            Symbol = symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Symbol);
        }
    }
}
