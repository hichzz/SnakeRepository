using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        private int coordX;
        private int coordY;
        private char symbol;
        
        public Point()
        {

        }

        public Point(int x, int y, char sym)
        {
            coordX = x;
            coordY = y;
            symbol = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(coordX, coordY);
            Console.WriteLine(symbol);
        }
    }
}
