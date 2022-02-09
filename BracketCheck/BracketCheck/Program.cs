using System;
using System.Collections.Generic;

namespace BracketCheck
{
    class Program
    {

        public static string input = "if((a + b) {a + b} [ a + b])";
        public static Stack<char> bracketStack = new Stack<char>();

        static void Main()
        {
            if (CheckBracket())
            {
                Console.WriteLine("유효한 괄호 배치");
            }
            else
            {
                Console.WriteLine("잘못된 괄호 배치");
            }
        }

        static bool CheckBracket()
        {
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '(':
                    case '{':
                    case '[':
                        bracketStack.Push(input[i]);
                        break;

                    case ')':
                        if(bracketStack.Count == 0)
                        {
                            return false;
                        }
                        else
                        {
                            if (bracketStack.Peek() == '(') 
                                bracketStack.Pop();
                        }
                        break;

                    case '}':
                        if (bracketStack.Count == 0)
                        {
                            return false;
                        }
                        else
                        {
                            if (bracketStack.Peek() == '{') 
                                bracketStack.Pop();
                        }
                        break;

                    case ']':
                        if (bracketStack.Count == 0)
                        {
                            return false;
                        }
                        else
                        {
                            if (bracketStack.Peek() == '[')
                                bracketStack.Pop();
                        }
                        break;
                    

                    default:
                        break;
                }
            }
            return bracketStack.Count == 0;
        }
    }
}
