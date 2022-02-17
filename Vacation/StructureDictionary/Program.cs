using System;
using System.Linq;
using System.Threading;
using System.Collections;
using static System.Console;
using System.Collections.Generic;

namespace StructureDictionary
{
    struct Word
    {
        public string data;
        public string discription;

        public Word(string _data, string _discription)
        {
            data = _data;
            discription = _discription;
        }
        
    }

    public class MyComparer : IComparer
    {
        public int Compare(object _x, object _y)
        {
            Word x = (Word)_x;
            Word y = (Word)_y;

            return x.data.CompareTo(y.data);
        }
    }

    class Program
    {
        const int ARRAY_SIZE = 100000000;
        static Word[][] dictionary = new Word[ARRAY_SIZE][];
        static IComparer myComparer = new MyComparer();

        static void Main(string[] args)
        {
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
                    Insert();
                }
                else if (input == 2)
                {
                    Remove();
                }
                else if (input == 3)
                {
                    Find();
                }
                else if (input == 4)
                {
                    PrintWords(myComparer);
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

        static void Insert()
        {
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Word[] temp = dictionary[i];

                if(temp == null)
                {
                    Console.WriteLine("몇개의 단어를 추가하실 예정이신지요?");
                    Console.Write(">> ");
                    if(int.TryParse(ReadLine(), out int input))
                    {
                        dictionary[i] = new Word[input];

                        for (int j = 0; j < dictionary[i].Length; j++)
                        {
                            Console.WriteLine($"총 {dictionary[i].Length}개의 단어 중 {j + 1} 번째 단어 입력입니다");
                            Console.WriteLine("먼저 단어를 입력해 주세요");
                            Console.Write(">> ");
                            string data = ReadLine();
                            Console.WriteLine("다음으로 의미를 입력해 주세요");
                            Console.Write(">> ");
                            string discription = ReadLine();
                            dictionary[i][j] = new Word(data, discription);
                        }
                        dictionary[i] = dictionary[i].Distinct().ToArray();
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다 시작화면으로 돌아갑니다");
                    }
                    
                    break;
                }
            }
        }

        static void Remove()
        {
            Console.WriteLine("어떤 단어를 삭제할 예정이신지요?");
            Console.Write(">> ");
            string word = ReadLine();
            bool isExisted = false;

            for (int i = 0; i < dictionary.Length; i++)
            {
                if(dictionary[i] != null)
                {
                    List<Word> wordList = dictionary[i].ToList();
                    Word temp = wordList.Find(x => x.data == word);

                    if (!temp.Equals(default(Word)))
                    {
                        wordList.Remove(temp);
                        dictionary[i] = wordList.ToArray();
                        Console.WriteLine($"{temp.data}를 삭제하셨습니다");
                        isExisted = true;
                        break;
                    }
                   
                }
            }
            if (!isExisted)
            {
                Console.WriteLine($"찾으시는 {word}가 존재하지 않습니다");
            }

        }

        static void Find()
        {
            Console.WriteLine("어떤 단어를 찾으실 예정이신지요?");
            Console.Write(">> ");
            string word = ReadLine();
            bool isExisted = false;

            for (int i = 0; i < dictionary.Length; i++)
            {
                if (dictionary[i] != null)
                {
                    List<Word> wordList = dictionary[i].ToList();
                    Word temp = wordList.Find(x => x.data == word);

                    if (!temp.Equals(default(Word)))
                    {
                        Console.WriteLine($"{temp.data}는 {temp.discription}라는 의미를 갖고 있는 단어입니다");
                        isExisted = true;
                        break;
                    }

                }

            }

            if (!isExisted)
            {
                Console.WriteLine($"찾으시는 {word}가 존재하지 않습니다");
            }
        }

        static void PrintWords(IComparer comparer)
        {
            List<Word> wordList = new List<Word>();
            for (int i = 0; i < dictionary.Length; i++)
            {
                if(dictionary[i] != null)
                {

                    dictionary[i].ToList().Sort((x, y) => x.data.CompareTo(y.data));

                    for (int j = 0; j < dictionary[i].Length; j++)
                    {
                        wordList.Add(dictionary[i][j]);
                    }
                }
            }
            Word[] words = wordList.ToArray();
            Array.Sort(words, comparer);

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {words[i].data}");
            }
        }
    }
}
