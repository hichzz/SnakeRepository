using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {
        private Direction Direction;
        public Snake(Point tail, int length, Direction direction)
        {
            Direction = direction;
            points = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, Direction);
                points.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = points.First();
            points.Remove(tail);
            Point head = GetNextPoint();
            points.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = points.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, Direction);
            return nextPoint;
        }

        internal bool IsHitTail()
        {
            var head = points.Last();
            for (int i = 0; i < points.Count - 2; i++)
            {
                if (head.IsHit(points[i]))
                    return true;
            }
            return false;
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    Direction = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    Direction = Direction.Right;
                    break;
                case ConsoleKey.DownArrow:
                    Direction = Direction.Down;
                    break;
                case ConsoleKey.UpArrow:
                    Direction = Direction.Up;
                    break;
            }
        }

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.symbol = head.symbol;
                points.Add(food);
                return true;
            }
            else
                return false;
        }
    }
}
