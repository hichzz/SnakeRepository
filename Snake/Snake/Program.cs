using System;
using System.Threading;

namespace Snake
{
    class Program
    {
		private const int MapHeight = 25;
		private const int MapWidth = 80;
		private const char SnakeSymbol = '*';
		private const char FoodSymbol = '$';
        static void Main(string[] args)
        {
			Console.SetWindowSize(MapWidth, MapHeight);
			Console.CursorVisible = false;

			Walls walls = new Walls(MapWidth, MapHeight);
			walls.Draw();

			Point p = new Point(4, 5, SnakeSymbol);
            Snake snake = new Snake(p, 4, Direction.Right);
            snake.Draw();


			FoodCreator foodCreator = new FoodCreator(MapWidth, MapHeight, FoodSymbol);
			Point food = foodCreator.CreateFood();
			food.Draw();

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
					food = foodCreator.CreateFood();
					food.Draw();
					GameMessages.DrawEatenFoodCounter(MapHeight, snake);
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
