using System.Collections.Generic;

namespace Snake
{
	class Walls
	{
		private List<Figure> walls;

		public Walls(int mapWidth, int mapHeight)
		{
			walls = new List<Figure>();

			// Отрисовка рамочки

			HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
			VerticalLine leftLine = new VerticalLine(0, 0, mapHeight - 1, '+');
			VerticalLine rightLine = new VerticalLine(mapWidth - 2, 0, mapHeight - 1, '+');

			HorizontalLine downLineTwo = new HorizontalLine(0, mapWidth - 2, mapHeight - 3, '+');

			walls.Add(upLine);
			walls.Add(downLine);
			walls.Add(leftLine);
			walls.Add(rightLine);
			walls.Add(downLineTwo);
		}

		internal bool IsHit(Figure figure)
		{
			foreach (var wall in walls)
			{
				if (wall.IsHit(figure))
				{
					return true;
				}
			}
			return false;
		}

		public void Draw()
		{
			foreach (var wall in walls)
			{
				wall.Draw();
			}
		}
	}
}