using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure
    {
        protected List<Point> points;
        public void Draw()
        {
            foreach (Point p in points)
            {
                p.Draw();
            }
        }
    }
}
