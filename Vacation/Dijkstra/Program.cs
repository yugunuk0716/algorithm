using System;
using System.Collections.Generic;


//우린 끝이야
//우린 다 망했어
//걍 끝이야 ㅠㅠ
namespace Dijkstra
{
    #region 사용자 입력

    class Dijkstra
    {

        private int[,] dijkstra;
        private int size;
        List<int> path = new List<int>();

        public Dijkstra(int _size)
        {
            size = _size;
            dijkstra = new int[size, size];
        }

        public void AddNode(int row, int col, int distance)
        {
            dijkstra[row, col] = distance;
            dijkstra[col, row] = distance;
        }
        public void Serch(int startNode, int destination)
        {
            bool[] visited = new bool[size];
            int[] distance = new int[size];
            int[] pastNodes = new int[size];

            Array.Fill(distance, int.MaxValue);

            distance[startNode] = 0;
            pastNodes[startNode] = startNode;

            while (true)
            {
                int now = -1;
                int closeNode = int.MaxValue;
                for (int i = 0; i < size; i++)
                {
                    if (visited[i])
                        continue;
                    if (distance[i] == int.MaxValue || distance[i] >= closeNode)
                        continue;


                    closeNode = distance[i];
                    now = i;
                }

                if (now == -1)
                    break;

                visited[now] = true;

                for (int next = 0; next < size; next++)
                {
                    if (dijkstra[now, next] == 0)
                        continue;
                    if (visited[next])
                        continue;

                    int nextDist = distance[now] + dijkstra[now, next];
                    if (nextDist < distance[next])
                    {
                        distance[next] = nextDist;
                        pastNodes[next] = now;
                    }
                }
            }
            FindPath(pastNodes, destination);
        }

        void FindPath(int[] pastNodes, int dest)
        {
            Console.WriteLine($"{dest}까지의 최단 경로");
            while (pastNodes[dest] != dest)
            {
                path.Add(dest);
                dest = pastNodes[dest];
            }

            path.Add(dest);
            path.Reverse();

            foreach (int item in path)
            {
                Console.WriteLine(item);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("몇개의 노드를 만들 것이냐?");
            Console.Write(">> ");
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                Dijkstra dijkstra = new Dijkstra(input);
                for (int i = 0; i < input; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("행을 입력하세요");
                    Console.Write(">> ");
                    if (int.TryParse(Console.ReadLine(), out int row))
                    {
                        if (row > input)
                            return;
                        Console.WriteLine("열을 입력하세요");
                        Console.Write(">> ");
                        if (int.TryParse(Console.ReadLine(), out int col))
                        {
                            if (col > input)
                                return;
                            Console.WriteLine("거리를 입력하세요");
                            Console.Write(">> ");
                            if (int.TryParse(Console.ReadLine(), out int distance))
                            {

                                dijkstra.AddNode(row, col, distance);
                            }

                        }
                    }
                }
                dijkstra.Serch( input - 1, 0);
            }
        }
    }
    #endregion
}



#region 입력 해놓기
//class DijkstraSerch
//{
//    const int nodeCount = 6;
//    int[,] nodes = new int[nodeCount, nodeCount]
//    {
//        {-1, 15, -1, 35, -1, -1},
//        {15, -1  5, 10, -1, -1},
//        {-1, 5, -1, -1, -1, -1},
//        {35, 10, -1, -1, 5, -1},
//        {-1, -1, -1, 5, -1, 5},
//        {-1, -1, -1, -1, 5, -1}
//    };
//    public void Serch(int startNum)
//    {
//        bool[] visited = new bool[nodeCount];
//        int[] distance = new int[nodeCount];
//        Array.Fill(distance, int.MaxValue);
//        int[] pastNode = new int[nodeCount];

//        distance[startNum] = 0;
//        pastNode[startNum] = startNum;
//        while (true)
//        {
//            int closer = int.MaxValue;
//            int now = -1;

//            for (int i = 0; i < nodeCount; i++)
//            {
//                if (visited[i])
//                    continue;

//                if (distance[i] == int.MaxValue || distance[i] >= closer)
//                    continue;

//                closer = distance[i];
//                now = i;
//            }
//            if (now == -1)
//                break;
//             visited[now] = true;
//            Console.WriteLine($"{now}번째 정점에 방문했습니다");

//            for (int next = 0; next < nodeCount; next++)
//            {
//                if (nodes[now, next] == 0)
//                    continue;
//                if (visited[next])
//                    continue;

//                int nextDist = distance[now] + nodes[now, next];

//                if (nextDist < distance[next])
//                {
//                    distance[next] = nextDist;
//                    pastNode[next] = now;
//                }
//            }

//        }
//    }

//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        DijkstraSerch dijkstra = new DijkstraSerch();

//        dijkstra.Serch(2);

//    }
//}

#endregion

