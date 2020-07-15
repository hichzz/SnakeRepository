using System;
using System.Threading;

namespace Snake
{
    class Program
    {
		private const int MapHeight = 25;
		private const int MapWidth = 80;
        static void Main(string[] args)
        {
			Console.SetWindowSize(MapWidth, MapHeight);
			Console.CursorVisible = false;

			Walls walls = new Walls(MapWidth, MapHeight);
			walls.Draw();

			Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();


			FoodCreator foodCreator = new FoodCreator(MapWidth, MapHeight, '$');
			Point food = foodCreator.CreateFood();
			food.Draw();

			FoodLine foodLine = new FoodLine();
			while (true)
			{
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					snake.Clear();
					GameMessages.GameOver(MapWidth, MapHeight);
					break;
				}
				if (snake.Eat(food))
				{
					foodLine.IncrementCount();
					food = foodCreator.CreateFood();
					food.Draw();
					foodLine.ShowFood(MapHeight, '$');
				}
				else
				{
					snake.Move();
				}

				Thread.Sleep(100);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			Console.ReadLine();

		}

    }
}
