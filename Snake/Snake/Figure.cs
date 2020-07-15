using System.Collections.Generic;

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

		internal bool IsHit(Figure figure)
		{
			foreach (var p in points)
			{
				if (figure.IsHit(p))
					return true;
			}
			return false;
		}

		private bool IsHit(Point point)
		{
			foreach (var p in points)
			{
				if (p.IsHit(point))
					return true;
			}
			return false;
		}

		public void Clear()
		{
			foreach (Point point in points)
			{
				point.Clear();
			}
		}
	}
}
