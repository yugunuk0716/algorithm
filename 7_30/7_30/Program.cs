using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

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