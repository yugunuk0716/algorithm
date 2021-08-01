using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace _7_29
{
    class Program
    {
        static void Main()
        {
            string _pNum = ReadLine();
            List<char> pNum = new List<char>();
            if (_pNum.Length < 20 && _pNum.Length > 4)
            {
                foreach (char num in _pNum)
                {
                    pNum.Add(num);
                }
                PhoneNum(pNum);

            }
        }
        static void PhoneNum(List<char> pNum)
        {
            for (int i = 0; i < pNum.Count; i++)
            {
                if (i < pNum.Count - 4)
                {
                    Write(pNum[i]);
                }
                else
                {
                    Write("*");
                }
            }
        }
        

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
//            Write("*");
//        }
//        else
//        {
//            Write(pNum[i]);
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

