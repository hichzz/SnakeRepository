using System;

namespace Snake
{
    static class GameMessages
    {
        static public void GameOver(int mapWidth, int mapHeight)
        {
            Console.SetCursorPosition(mapWidth / 2 - 9, mapHeight / 2);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
        }
    }
}
