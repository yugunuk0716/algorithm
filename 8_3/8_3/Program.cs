using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

namespace _8_3
{
    class Program
    {



    }
}
#region 11번
//static void Main(string[] args)
//{
//    int n = int.Parse(ReadLine());
//
//    WriteLine(Sum(n));
//}
//static int Sum(int input)
//{
//    List<int> nums = new List<int>();
//    int x = 0;
//
//    nums = input.ToString().Select(o => Convert.ToInt32(o) - '0').ToList();
//    nums.ForEach((item) => { x += item; });
//    return x;
//}
#endregion
#region 12번
//static void Main()
//{
//    Write(SumNums(3, 6));
//}
//static int SumNums(int a, int b) 
//{
//    int count = a > b ? a - b + 1 : b - a + 1;
//    int sum = (a + b) * count / 2;
//
//    return sum;
//}
#endregion
#region 13번
//static void Main()
//{
//    Write(Caesar(ReadLine(),int.Parse(ReadLine())));
//}

//static string Caesar(string origin, int dist)
//{
//    string answer = string.Empty;
//    int sum = 0;
//    char transe = '0';

//    if (origin.Length <= 8000 && 1 <= dist && dist <= 5)
//    {
//        char[] orings = origin.ToCharArray();
//        foreach (var item in orings)
//        {
//            if (item != ' ')
//            {

//                sum = (int)item + dist;


//                if (sum > 'Z')
//                {
//                    sum -= 1;
//                    transe = (char)('A' + (char)sum - 'Z');
//                }
//                else if (sum > 'z')
//                {
//                    sum -= 1;
//                    transe = (char)('a' + (char)sum - 'z');
//                }
//                else
//                {
//                    transe = (char)sum;
//                }
//            }
//            else
//            {
//                transe = ' ';
//            }
//            answer += transe.ToString();
//        }
//        return answer;
//    }

//    return "원문의 길이는 8000자까지만 가능합니다, 그리고 원문으로 부터의 거리는 1이상 5이하입니다";
//}
#endregion
#region 14번
//static void Main() 
//{
//    string str = ReadLine();
//
//    if (1 <= str.Length && str.Length <= 5) 
//    {
//        Write(Stoi(str));
//    }
//}

//static int Stoi(string input)
//{

//    return int.Parse(input);

//}

#endregion
#region 15번
//static void Main()
//{
//    Write(Soobaksoobak(int.Parse(ReadLine())));
//}

//static string Soobaksoobak(int n)
//{
//    string answer = string.Empty;

//    for (int i = 0; i < n; i++)
//    {
//        answer += i % 2 == 0 ? "수" : "박";
//    }
//    return answer;


//}
#endregion
