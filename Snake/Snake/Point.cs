using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int coordX;
        public int coordY;
        public char symbol;
        
        public Point()
        {

        }

        public Point(Point p)
        {
            coordX = p.coordX;
            coordY = p.coordY;
            symbol = p.symbol;
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

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    coordX -= offset;
                    break;
                case Direction.Right:
                    coordX += offset;
                    break;
                case Direction.Up:
                    coordY -= offset;
                    break;
                case Direction.Down:
                    coordY += offset;
                    break;
            }

        }

        public bool IsHit(Point p)
        {
            return p.coordX == this.coordX && p.coordY == this.coordY;
        }

        public void Clear()
        {
            symbol = ' ';
            Draw();
        }

        public override string ToString()
        {
            return coordX + ", " + coordY + ", " + symbol;
        }
    }
}
