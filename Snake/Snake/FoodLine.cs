using System.Collections.Generic;

namespace Snake
{
    class FoodLine : Figure
    {
        private const int VerticalShift = 2;
        private const int HorizontalShift = 4;
        private const int BorderHeight = 1;

        public int CountEatenFood;
                  
        public FoodLine()
        {
            points = new List<Point>();
        }
        private void DrawCounter(int mapHeight)
        {
            char[] counterChars = CountEatenFood.ToString().ToCharArray();
            for (int i = 0; i < counterChars.Length; i++)
            {
                DrawSymbol(BorderHeight + i, mapHeight - VerticalShift, counterChars[i]);
            }
        }

        private void DrawSymbol(int x, int y, char symbol) => (new Point(x, y, symbol)).Draw();

        public void IncrementCount() => CountEatenFood++;

        public void ShowFood(int mapHeight, char symbol)
        {
            Clear();
            DrawCounter(mapHeight);
            for (int i = 1; i <= CountEatenFood; i++)
            {
                DrawSymbol(HorizontalShift + i, mapHeight - VerticalShift, symbol);
            }
        }
    }
}
