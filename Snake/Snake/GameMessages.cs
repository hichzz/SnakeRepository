using System;

namespace Snake
{
    static class GameMessages
    {
        private const int HorizontalMessageShift = 9;
        private const int VerticalMessageShift = 2;
        private const int SymbolShift = 2;

        static public void GameOver(int mapWidth, int mapHeight)
        {
            Console.SetCursorPosition(mapWidth / VerticalMessageShift - HorizontalMessageShift, mapHeight / VerticalMessageShift);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
        }

        static public void DrawEatenFoodCounter(int mapHeight, Snake snake)
        {
            char[] counterChars = snake.CountEatenFood.ToString().ToCharArray();
            for (int i = 0; i < counterChars.Length; i++)
            {
                new Point(SymbolShift + i, mapHeight - SymbolShift, counterChars[i]).Draw();
            }
        }
    }
}
