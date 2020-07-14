using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int yUp, int yDown, char symbol)
        {
            points = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, symbol);
                points.Add(p);
            }
        }
    }
}
