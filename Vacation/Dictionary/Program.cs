using System;
using static System.Console;
using System.Collections.Generic;
using System.Threading;

namespace Dictionary
{
    public class BinaryTreeNode<T>
    {
        public T Data { get; set; }

        public BinaryTreeNode<T> Left { get; set; }

        public BinaryTreeNode<T> Right { get; set; }

        public BinaryTreeNode(T data)
        {
            this.Data = data;
        }

    }

    public class BST<T>
    {
        private BinaryTreeNode<T> root = null;
        private Comparer<T> comparer = Comparer<T>.Default;
        private List<T> sortedDataList = new List<T>();
        public List<BinaryTreeNode<T>> nodeList = new List<BinaryTreeNode<T>>();

        public void Insert(T data)
        {

            BinaryTreeNode<T> node = root;

            if (node == null)
            {

                root = new BinaryTreeNode<T>(data);
                nodeList.Add(root);
                return;

            }

            while (node != null)
            {
                int result = comparer.Compare(node.Data, data);

                if (result == 0)
                {


                    return;

                }
                else if (result > 0)
                {

                    if (node.Left == null)
                    {
                        node.Left = new BinaryTreeNode<T>(data);
                        nodeList.Add(node.Left);
                        return;
                    }

                    node = node.Left;

                }
                else
                {
                    if (node.Right == null)
                    {
                        node.Right = new BinaryTreeNode<T>(data);
                        nodeList.Add(node.Right);
                        return;
                    }

                    node = node.Right;

                }

            }

        }

        public void PreOrderTraversal()
        {
            PreOrderRecursive(root);
        }

        private void PreOrderRecursive(BinaryTreeNode<T> node)
        {
            if (node == null) return;

            sortedDataList.Add(node.Data);
            PreOrderRecursive(node.Left);

            PreOrderRecursive(node.Right);
        }

        public List<T> GetSortedList()
        {
            sortedDataList.Sort((x, y) => comparer.Compare(x,y));
            return sortedDataList;
        }

    }



    class Program
    {
        static List<string> strList = new List<string>();

        static void Main(string[] args)
        {
            BST<string> bst = new BST<string>();
            int input = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("텍스트 편집기");
                Console.WriteLine("---1. 입력---");
                Console.WriteLine("---2. 삭제---");
                Console.WriteLine("---3. 탐색---");
                Console.WriteLine("---4. 출력---");
                Console.WriteLine("---5. 종료---");
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
                    Insert(bst);
                }
                else if (input == 2)
                {
                    Delete(bst);
                }
                else if (input == 3)
                {
                    FindNode(bst);
                }
                else if (input == 4)
                {
                    PrintNodes(bst);
                }
                else if (input == 5)
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

        static void Insert(BST<string> bst)
        {
            Console.WriteLine("어떤 내용을 삽입하실건가요?");
            Console.Write(">> ");
            bst.Insert(ReadLine());
        }

        static void Delete(BST<string> bst)
        {
            Console.WriteLine("어떤 단어를 지우실건가요?");
            Console.Write(">> ");
            string data = ReadLine();
            BinaryTreeNode<string> temp = bst.nodeList.Find(x => x.Data == data);

            if(temp != null)
            {
                temp.Data = null;
                bst.nodeList.Remove(temp);
            }
            else
            {
                Console.WriteLine("삭제를 시도한 단어가 존재하지 않습니다");
            }
        }

        static void FindNode(BST<string> bst)
        {
            Console.WriteLine("어떤 단어를 찾으실건가요?");
            Console.Write(">> ");
            string data = ReadLine();

            BinaryTreeNode<string> temp = bst.nodeList.Find(x => x.Data == data);

            if (temp != null)
            {
                Console.WriteLine($"{temp.Data}가 존재합니다");
            }
            else
            {
                Console.WriteLine("찾는 단어가 존재하지 않습니다");
            }
        }

        static void PrintNodes(BST<string> bst)
        {
            bst.PreOrderTraversal();
            strList = bst.GetSortedList();

            for (int i = 0; i < strList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {strList[i]}");
            }
        }
        

    }

}
