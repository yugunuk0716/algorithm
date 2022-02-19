using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astar
{
    class Node
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int F { get; set; }
        public int G { get; set; }
        public int H { get; set; }
        public Node Parent { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "A* Pathfinding";

            string[] map = new string[]
            {
                "+------------+",
                "|     X      |",
                "|  X     X  B|",
                "|  X     X   |",
                "|  X     X   |",
                "|A X     X   |",
                "|            |",
                "+------------+",
            };
            var start = new Node { X = 1, Y = 5 };
            var target = new Node { X = 12, Y = 2 };

            int SLEEP_TIME = 100;

            foreach (var line in map)
                Console.WriteLine(line);

            Node current = null;
            var openList = new List<Node>();
            var closedList = new List<Node>();
            int g = 0;

            openList.Add(start);

            while (openList.Count > 0)
            {
                var lowest = openList.Min(l => l.F);
                current = openList.First(l => l.F == lowest);

                closedList.Add(current);

                Console.SetCursorPosition(current.X, current.Y);
                Console.Write('.');
                Console.SetCursorPosition(current.X, current.Y);
                System.Threading.Thread.Sleep(SLEEP_TIME);

                openList.Remove(current);

                if (closedList.FirstOrDefault(l => l.X == target.X && l.Y == target.Y) != null)
                    break;

                var adjacentSquares = GetWalkableAdjacentSquares(current.X, current.Y, map, openList);
                g = current.G + 1;

                foreach (var adjacentSquare in adjacentSquares)
                {
                    if (closedList.FirstOrDefault(l => l.X == adjacentSquare.X
                        && l.Y == adjacentSquare.Y) != null)
                        continue;

                    if (openList.FirstOrDefault(l => l.X == adjacentSquare.X
                        && l.Y == adjacentSquare.Y) == null)
                    {
                        adjacentSquare.G = g;
                        adjacentSquare.H = ComputeHScore(adjacentSquare.X, adjacentSquare.Y, target.X, target.Y);
                        adjacentSquare.F = adjacentSquare.G + adjacentSquare.H;
                        adjacentSquare.Parent = current;

                        openList.Insert(0, adjacentSquare);
                    }
                    else
                    {
                        if (g + adjacentSquare.H < adjacentSquare.F)
                        {
                            adjacentSquare.G = g;
                            adjacentSquare.F = adjacentSquare.G + adjacentSquare.H;
                            adjacentSquare.Parent = current;
                        }
                    }
                }
            }

            Node end = current;

            while (current != null)
            {
                Console.SetCursorPosition(current.X, current.Y);
                Console.Write('_');
                Console.SetCursorPosition(current.X, current.Y);
                current = current.Parent;
                System.Threading.Thread.Sleep(SLEEP_TIME);
            }

            if (end != null)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("Path : {0}", end.G);
            }

            Console.ReadLine();
        }

        static List<Node> GetWalkableAdjacentSquares(int x, int y, string[] map, List<Node> openList)
        {
            List<Node> list = new List<Node>();

            if (map[y - 1][x] == ' ' || map[y - 1][x] == 'B')
            {
                Node node = openList.Find(l => l.X == x && l.Y == y - 1);
                if (node == null) list.Add(new Node() { X = x, Y = y - 1 });
                else list.Add(node);
            }

            if (map[y + 1][x] == ' ' || map[y + 1][x] == 'B')
            {
                Node node = openList.Find(l => l.X == x && l.Y == y + 1);
                if (node == null) list.Add(new Node() { X = x, Y = y + 1 });
                else list.Add(node);
            }

            if (map[y][x - 1] == ' ' || map[y][x - 1] == 'B')
            {
                Node node = openList.Find(l => l.X == x - 1 && l.Y == y);
                if (node == null) list.Add(new Node() { X = x - 1, Y = y });
                else list.Add(node);
            }

            if (map[y][x + 1] == ' ' || map[y][x + 1] == 'B')
            {
                Node node = openList.Find(l => l.X == x + 1 && l.Y == y);
                if (node == null) list.Add(new Node() { X = x + 1, Y = y });
                else list.Add(node);
            }

            return list;
        }

        static int ComputeHScore(int x, int y, int targetX, int targetY)
        {
            return Math.Abs(targetX - x) + Math.Abs(targetY - y);
        }
    }
}