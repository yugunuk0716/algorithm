using System;
using static System.Console;
using System.Collections.Generic;
using System.Threading;

namespace TextEditor
{
    class Program
    {
        public static List<string> textList = new List<string>();
        public static List<string> deltedTextList = new List<string>();

        static void Main()
        {
            TextEdit();
        }

        static void TextEdit()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("텍스트 편집기");
                Console.WriteLine("---1. 삽입---");
                Console.WriteLine("---2. 삭제---");
                Console.WriteLine("---3. 보기---");
                Console.WriteLine("---4. 복원---");
                Console.WriteLine("---5. 종료---");
                Console.Write(">> ");
                int input = int.Parse(ReadLine());

                if (input == 1)
                {
                    PutText();
                }
                else if(input == 2)
                {
                    RemoveText();
                } 
                else if(input == 3)
                {
                    DrawText();
                }
                else if(input == 4)
                {
                    RestoreText();
                }
                else if (input == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다 다시 입력하세연");
                    continue;
                }
                Console.WriteLine("메인으로 가는 중입니다 잠시만 기다려 주세요");
                Thread.Sleep(3000);
                
            }
        }


        static void DrawText()
        {
            if(textList.Count == 0)
            {
                Console.WriteLine("아쉽게도 아직 문서에 아무것도 없습니다 무에서 유를 창조하는 것은 불가능하기 때문에 한번이라고 입력하고 다시 시도하세요");
            }
            for (int i = 0; i < textList.Count; i++)
            {
                WriteLine($"{i+1}. {textList[i]}");
            }

        }

        static void PutText()
        {
            Console.WriteLine("어떤 내용을 삽입하실건가요?");
            Console.Write(">> ");
            textList.Add(ReadLine());
            WriteLine($"{textList.Count}번 째 줄에 삽입했습니다");
        }

        static void RemoveText()
        {
            Console.WriteLine("모든 줄을 지우시겠습니까? Y/N");
            Console.Write(">> ");

            string input = ReadLine().ToLower();
            if (input == "y")
            {
                RemoveAll();
            }
            else if (input == "n")
            {
                Console.Write("몇 번째 줄을 삭제하실건가요 ");
                int lineNum = int.Parse(ReadLine());


                if (textList.Count < lineNum || lineNum < 1 )
                {
                    
                    Console.WriteLine($"{lineNum}에 해당하는 줄이 없는데요? 이 문서에는 현제 총 {textList.Count}줄이 있습니다");
                    return;
                }

                

                deltedTextList.Add(textList[lineNum - 1]);
                textList.RemoveAt(lineNum - 1);
                WriteLine($"{lineNum}번 째 줄을 삭제했습니다");
            }
            else
            {
                Console.WriteLine("아니 님아 Y랑 N중에 고르랬잖아요 한글 몰라요? 눈 없어요? 똑바로 안읽어요?");
                RemoveText();
            }
        }
        

        static void RemoveAll()
        {
            
            WriteLine($"정말 모든 줄을 삭제 하시겠습니까?  Y/N");
            Console.Write(">> ");

            string input = ReadLine().ToLower();
            if (input == "y")
            {
                for (int i = 0; i < textList.Count; i++)
                {
                    deltedTextList.Add(textList[i]);
                    textList.RemoveAt(i);

                }
                WriteLine($"모든 줄을 삭제했습니다");
            }
            else if(input == "n")
            {
                Console.WriteLine("다시 메인으로 갑니다");
            }
            else
            {
                Console.WriteLine("아니 님아 Y랑 N중에 고르랬잖아요 한글 몰라요? 눈 없어요? 똑바로 안읽어요?");
                RemoveAll();
            }
        }

        static void RestoreText()
        {
            if(deltedTextList.Count == 0)
            {
                Console.WriteLine("복원 가능한 내용이 없습니다");
                return;
            }

            for (int i = 0; i < deltedTextList.Count; i++)
            {
                WriteLine($"{i + 1}. {deltedTextList[i]}");
            }

            Console.WriteLine("몇번 째 줄을 복원하시겠습니까?");
            Console.Write(">> ");
            int index = int.Parse(ReadLine());
            if (deltedTextList.Count < index || index < 1)
            {
                Console.WriteLine($" 복원할 줄이 없습니다");
                return;
            }
            textList.Add(deltedTextList[index - 1]);
            WriteLine($"{textList.Count}번 째 줄에 복원했습니다");

        }
    }
    
}
