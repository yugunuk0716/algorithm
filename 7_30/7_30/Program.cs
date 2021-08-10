using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
#region 문제들
//[문제 06] 최대공약수와 최소공배수
//두 수를 입력받아 두 수의 최대공약수와 최소공배수를 반환하는 함수를 완성해보세요. 배열의 맨 앞에 최대공약수, 그다음 최소공배수를 넣어 반환하면 됩니다. 예를 들어 두 수 3, 12의 최대공약수는 3, 최소공배수는 12이므로 solution(3, 12)는 3, 12를 반환해야 합니다.
//(두 수는 1 이상 1000000이하의 자연수입니다.)
 
 
//[문제 07] x만큼 간격이 있는 n개의 숫자
//함수 solution은 정수 x와 자연수 n을 입력받아, x부터 시작해 x씩 증가하는 숫자를 n개 지니는 리스트를 return 해야 합니다. 다음 제한조건을 보고, 조건을 만족하는 함수 solution을 완성해주세요.
//(제한조건) – x는 - 10000000 이상, 10000000 이하인 정수입니다.
// - n은 1000 이하인 자연수입니다.



// [문제 08] 콜라츠 추측
//1937년 Collatz란 사람에 의해 제기된 이 추측은, 주어진 수가 1이 될 때까지 다음 작업을 반복하면, 모든 수를 1로 만들 수 있다는 추측입니다.작업은 다음과 같습니다.
 

//1-1. 입력된 수가 짝수라면 2로 나눕니다.
//1-2. 입력된 수가 홀수라면 3을 곱하고 1을 더합니다.
//2. 결과로 나온 수에 같은 작업을 1이 될 때까지 반복합니다.


// 예를 들어, 입력된 수가 6이라면 6 → 3 → 10 → 5 → 16 → 8 → 4 → 2 →1 이 되어 총 8번 만에 1이 됩니다. 위 작업을 몇 번이나 반복해야 하는지 반환하는 함수 solution을 완성해주세요. 단, 작업을 500번을 반복해도 1이 되지 않는다면 –1을 반환해 주세요.
 


// [문제 09] 정수 내림차순으로 배치하기
// 함수 solution은 정수 n을 매개변수로 입력받습니다. n의 각 자릿수를 큰 것부터 작은 순으로 정렬한 새로운 정수를 return 해 주세요. 예를 들어, n이 118372면 873211을 return 하면 됩니다.
//(n은 1 이상 8000000000 이하인 자연수입니다.)



//[문제 10] 자연수 뒤집어 배열로 만들기
//자연수 n을 뒤집어 각 자리 숫자를 원소로 가지는 배열 형태로 return 해 주세요. 예를 들어 n이 12345이면 [5,4,3,2,1]
//을 리턴합니다.
#endregion
namespace _7_30
{
    class Program
    {
    }
}

#region 6번
//    static void Main(string[] args)
//    {
//        int x = int.Parse(ReadLine());
//        int y = int.Parse(ReadLine());

//        if (1 <= x && x <= 1000000 && 1 <= y && y <= 1000000)
//        {
//            WriteLine(Return(x, y));
//        }
//    }

//    static double Multiple(int x, int y)
//    {
//        for (int i = 1; i < x; i++)
//        {
//            int t = i * y;
//            for (int k = 1; k < y; k++)
//            {
//                int a = k * x;
//                if (a == t)
//                {
//                    return t;
//                }

//            }

//        }


//        return x * y;

//    }
//    static double Div(int x, int y) 
//    {

//        for (int i = x; i > 0; i--)
//        {
//            int t = i % y == 0?  y : i;

//            for (int k = y; k > 0; k--)
//            {
//                int a = k / x == 0? x : k ;

//                if (a == t) 
//                {
//                    return a;
//                }
//            }

//        }

//        if (x / y == 0) 
//        {
//            return y;
//        }
//        return x;
//    }
//    static string Return(int x, int y) 
//    {
//        string d = Div(x, y).ToString();
//        string m = Multiple(x, y).ToString();

//        return d + " " + m;
//    }
//}
#endregion
#region 7번
//static void Main()
//{
//    foreach (var e in Geometric(3, 3))
//    {
//        WriteLine(e);
//    };
//}

//static List<int> Geometric(int x, int n)
//{
//    List<int> nums = new List<int>();
//    if (-10000000 < x && x < 10000000 && 0< n && n < 1000)
//    {
//        int num = 0;
//        for (int i = 0; i < n; i++)
//        {
//            num += x;
//            nums.Add(num);
//        }
//    }
//    else
//    {
//        WriteLine("안 돼 돌아가 안바꿔줘");
//    }

//    return nums;
//}
#endregion
#region 8번
//public static int count;
//static void Main()
//{
//    int i = int.Parse(ReadLine());
//    if (0 < i && i < int.MaxValue)
//    {
//        Write(Collatz(i));
//    }
//    else
//    {
//        WriteLine("입력 가능한 숫자의 범위는 자연수입니다~");
//    }
//}
//static int Collatz(int input)
//{
//    count++;
//    int temp = input % 2 == 0 ? input / 2 : (input * 3) + 1;

//    if (temp != 1)
//    {
//        Collatz(temp);
//    }

//    if (count >= 500)
//    {
//        return -1;
//    }

//    return count;
//}
#endregion
#region 9번
//static void Main()
//{
//    long i = long.Parse(ReadLine());
//    Write(Descending(i));
//}
//static string Descending(long num)
//{
//    if (1 < num && num < 8000000000) 
//    {
//        long[] arr = num.ToString().Select(o => Convert.ToInt64(o) - '0').ToArray();
//        List<long> nums = new List<long>();
//        string temp = string.Empty;

//        for (int i = 0; i < arr.Length; i++)
//        {
//            nums.Add(arr[i]);
//        }
//        nums.Sort((x, y) => y.CompareTo(x));
//        foreach (var item in nums)
//        {
//            temp += item.ToString();
//        }
//        return temp;
//    }
//    else
//    {
//        return "안 돼";
//    }
//}
#endregion
#region 10번
//static void Main() 
//{
//    int n = int.Parse(ReadLine());
//    Reverse(n);
//}

//static int[] Reverse(int n)
//{
//    int[] arr = n.ToString().Select(o => Convert.ToInt32(o) - '0').ToArray();
//    List<int> nums = new List<int>();
//    for (int i = arr.Length-1; i >= 0; i--)
//    {
//        WriteLine(arr[i]);
//        nums.Add(arr[i]);
//    }

//    return arr.ToArray();
//}
#endregion