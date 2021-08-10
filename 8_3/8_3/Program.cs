using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;
#region 문제들
//[문제 11] 자릿수 더하기
//자연수 N이 주어지면, N의 각 자릿수의 합을 구해서 return 하는 soulution 함수를 만들어주세요. 예를 들어 N이 123이면 1 + 2 + 3 = 6을 return 하면 됩니다.



//[문제 12] 두 정수 사이의 합
//두 정수 a, b가 주어졌을 때 a와 b 사이에 속한 모든 정수의 합을 return 하는 함수를 완성하세요. 예를 들어 a = 3, b = 5인 경우, 3 + 4 + 5 = 12이므로 12를 return 합니다.


//[문제 13] 시저 암호
//어떤 문장의 각 알파벳을 일정한 거리만큼 밀어서 다른 알파벳으로 바꾸는 암호화 방식을 시저 암호라고 합니다. 예를 들어 “AB”는 1만큼 밀면 “BC”가 되고, 3만큼 밀면 “DE”가 됩니다. “z”는 1만큼 밀면 “a”가 됩니다. 문자열 s와 거리 n을 입력받아 s를 n만큼 민 암호문을 만드는 함수를 완성해보세요.
//(공백은 아무리 밀어도 공백입니다. s는 알파벳 소문자, 대문자, 공백으로만 이루어져 있습니다. s의 길이는 8000 이하입니다. n은 1 이상, 25 이하인 자연수입니다.)
 
 
//[문제 14] 문자열을 정수로 바꾸기
//문자열 s를 숫자로 변환한 결과를 반환하는 함수를 완성하세요.
//(s의 길이는 1 이상 5 이하입니다. s의 맨 앞에는 부호(+,-)가 올 수 있습니다. s는 부호와 숫자로만 이루어져 있습니다. s는 “0”으로 시작하지 않습니다.)
 
 
//[문제 15] 수박수박수박수박수박수?
//길이가 n이고, “수박수박수박수…”와 같은 패턴을 유지하는 문자열을 return 하는 함수를 완성하세요. 예를 들어 n이 4이면 “수박수박”을 return하고 3이라면 “수박수”를 return 하면 됩니다.
#endregion
namespace _8_3
{
    class Program
    {
        static void Main() 
        {
        }

      
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
//
//    return (a + b) * count / 2;
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
//
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
//
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
//
//    return answer;
//}
#endregion
