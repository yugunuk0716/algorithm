using System;
using static System.Console;
using System.Collections.Generic;
using System.Threading;

namespace PriorityQueue
{
    struct PriorityNode<T>
    {
        public T data;
        public int priority;


        public PriorityNode(T _data, int _priority)
        {
            data = _data;
            priority = _priority;
        }
    }

    class Heap<T>
    {
        public List<PriorityNode<T>> heap = new List<PriorityNode<T>>();

        public void Enqueue(T data ,int priority)
        {
            heap.Add(new PriorityNode<T>(data, priority));

            int now = heap.Count - 1; 

            while (now > 0)
            {
                int next = (now - 1) / 2;


                if (heap[now].priority < heap[next].priority)
                    break;

                PriorityNode<T> node = heap[now];
                heap[now] = heap[next];
                heap[next] = node;
                now = next;

            }
        }

        public PriorityNode<T> Dequeue()
        {
            PriorityNode<T> rootNode = heap[0];
            Console.WriteLine($"{rootNode.priority}");
            int lastIndex = heap.Count - 1;

            heap[0] = heap[lastIndex]; 
            heap.RemoveAt(lastIndex);
            lastIndex--;

            int now = 0; 
            while (true) 
            {
                int left = 2 * now + 1;
                int right = 2 * now + 2; 

                int next = now;

                if (left <= lastIndex && heap[next].priority < heap[left].priority)
                    next = left;
                if (right <= lastIndex && heap[next].priority < heap[left].priority)
                    next = right;

                if (now == next)
                    break;

                PriorityNode<T> node = heap[now];
                heap[now] = heap[next];
                heap[next] = node;
                now = next;

            }

            return rootNode;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Heap<int> heap = new Heap<int>();
            int input = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("텍스트 편집기");
                Console.WriteLine("---1. 인큐---");
                Console.WriteLine("---2. 디큐---");
                Console.WriteLine("---3. 종료---");
                Console.Write(">> ");

                if (int.TryParse(ReadLine(), out int result))
                {
                    input = result;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다 다시 메인으로 돌아갑니다");
                    Thread.Sleep(1000);
                    continue;
                }



                if (input == 1)
                {
                    Console.WriteLine("우선순위를 입력해주세요");
                    Console.Write(">>");
                    if(int.TryParse(ReadLine(), out int priority))
                    {
                        Console.WriteLine("데이터를를 입력해주세요");
                        Console.Write(">>");
                        if (int.TryParse(ReadLine(), out int data))
                        {
                            heap.Enqueue(data, priority);
                        }
                        else
                        {
                            Console.WriteLine("데이터가 이상하게 들어온듯? 정수형만 될 듯? 다시 메인으로 가야 될 듯?");
                            Thread.Sleep(1000);
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("우선순위가 이상하게 들어온듯? 정수형만 될듯? 다시 메인으로 가야 될 듯?");
                        Thread.Sleep(1000);
                        continue;
                    }
                }
                else if (input == 2)
                {
                    PriorityNode<int> node = heap.Dequeue();

                    if (!node.Equals(default(PriorityNode<int>)))
                    {
                        Console.WriteLine($"우선순위: {node.priority} 데이터 {node.data}를 큐에서 뻇음");
                    }
                    else
                    {
                        Console.WriteLine("노드가 없는것 같은데 메인으로 가야 될 듯?");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다 메인으로 돌아갑니다");
                    Thread.Sleep(1000);
                    continue;
                }
                Console.WriteLine("메인으로 가는 중입니다 잠시만 기다려 주세요");
                Thread.Sleep(3000);

            }
        }
    }
}
