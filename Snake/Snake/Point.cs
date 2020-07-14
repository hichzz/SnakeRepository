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

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Symbol);
        }
    }
}
