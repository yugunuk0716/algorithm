using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
#region 문제들
//[문제 01] 직사각형 별 찍기
//이 문제에는 표준 입력으로 두 개의 정수 n과 m이 주어집니다. 별(*) 문자를 이용해 가로의 길이가 n, 세로의 길이가 m인 직사각형 형태를 출력해보세요.
//(n과 m은 각각 1000 이하인 자연수입니다.)
 
 
//[문제 02] 짝수와 홀수
//정수 num이 짝수일 경우 “Even”을 반환하고, 홀수인 경우 “Odd”를 반환하는 함수를 완성해주세요.
//(num은 int 범위의 정수입니다. 0은 짝수입니다.)
 
 
//[문제 03] 핸드폰 번호 가리기
//개인정보 보호를 위해 고지서를 보낼 때 고객들의 전화번호의 일부를 가립니다.
//전화번호가 문자열 phone_number로 주어졌을 때, 전화번호의 뒷 4자리를 제외한 나머지 숫자를 전부 *으로 가린 문자열을 return 하는 함수를 완성해주세요.
//(s는 길이 4 이상, 20이하인 문자열입니다.)
 
 
//[문제 04] 평균 구하기
//정수를 담고 있는 배열 arr의 평균값을 return하는 함수를 완성해보세요.
//(arr은 길이 1 이상, 100이하인 배열입니다. arr의 원소는 –10,000 이상 10,000 이하인 정수입니다.)
 
 
//[문제 05] 제일 작은 수 제거하기
//정수를 저장한 배열, arr에서 가장 작은 수를 제거한 배열을 리턴하는 함수를 완성해주세요.
//단, return 하려는 배열이 빈 배열인 경우엔 배열에 –1을 채워 return 하세요. 예를 들어 arr이 [4,3,2,1]인 경우는[4, 3, 2]를 return 하고, [10]이면 [-1] 를 return 합니다.
//  (arr는 길이 1 이상인 배열입니다.인덱스 i, j에 대해 i ≠ j이면 arr[i] ≠ arr[j] 입니다.)
//  (입력된 수, num은 1 이상 8000000 미만인 정수입니다.)
#endregion
namespace _7_29
{
    class Program
    {
       
        

    }
}
#region 1번
//static void Main(string[] args)
//        {
//     
//            int n = int.Parse(ReadLine());
//            int m = int.Parse(ReadLine());
//            if (n < 1000 && m < 1000) 
//            {
//                Box(n, m);
//            }
//        }

//        static void Box(int n, int m)
//        {
//            for (int i = 0; i < n; i++)
//            {
//                for (int k = 0; k < m; k++)
//                {
//                    Write("*");
//                }
//                WriteLine();
//            }
//        }
#endregion
#region 2번
//static void Main()
//{
//    string sNum = ReadLine();
//    int num = int.Parse(sNum);
//    WriteLine(Num(num));
//}
//static string Num(int num)
//{
//    if (num % 2 == 0 || num == 0)
//    {
//        return "Even";
//    }
//    else
//    {
//        return "Odd";
//    }
//}
#endregion
#region 3번
//static void Main()
//{
//    string _pNum = ReadLine();
//    List<char> pNum = new List<char>();
//    if (_pNum.Length < 20 && _pNum.Length > 4)
//    {
//        foreach (char num in _pNum)
//        {
//            pNum.Add(num);
//        }
//        PhoneNum(pNum);

//    }
//}
//static void PhoneNum(List<char> pNum)
//{
//    for (int i = 0; i < pNum.Count; i++)
//    {
//        if (i < pNum.Count - 4)
//        {
//            Write(pNum[i]);
//        }
//        else
//        {
//            Write("*");
//        }
//    }
//}
#endregion
#region 4번
//static void Main()
//{
//    int[] ints = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//    int sum = 0;
//    if (ints.Length <= 100 && ints.Length >= 1)
//    {
//        for (int i = 0; i < ints.Length; i++)
//        {
//            if (-10000 < ints[i] && ints[i] < 10000)
//            {
//                sum += ints[i];
//            }
//        }
//        WriteLine((double)sum / ints.Length);
//    }
//}
#endregion
#region 5번
//static void Main()
//{
//    int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//    Cut(nums);
//}
//static int[] Cut(int[] num)
//{
//    int[] arr = new int[] { };
//    if (num.Length <= 1)
//    {
//        arr = new int[] { -1 };
//        return arr;
//    }
//    int min = num.Min();
//     
//    arr = num.Select(x => x).Where(y => y != min).ToArray();
//    return arr;
//}
#endregion

