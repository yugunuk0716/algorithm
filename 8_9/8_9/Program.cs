using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace _8_9
{
    class Program
    {




    }
}
#region 21번
//static int[] Solution21(int[] numbers)
//{
//    List<int> result = new List<int>();

//    for (int i = 0; i < numbers.Length - 1; i++)
//    {
//        for (int j = i + 1; j < numbers.Length; j++)
//        {
//            if (!result.Contains(numbers[i] + numbers[j]))
//            {
//                result.Add(numbers[i] + numbers[j]);
//            }
//        }
//    }
//    result.Sort();

//    return result.ToArray();
//}
#endregion
#region 22번
//static void Main()
//{
//    WriteLine(Solution22("apple app about"));
//}

//static string Solution22(string s)
//{
//    string answer = string.Empty;
//    int wordCount = 0;

//    for (int i = 0; i < s.Length; i++)
//    {
//        if (s[i] == ' ')
//        {
//            answer += s[i];
//            wordCount = 0;
//            continue;
//        }
//        answer += wordCount % 2 == 0 ? s[i].ToString().ToUpper() : s[i].ToString().ToLower();
//        wordCount++;
//    }

//    return answer;
//}
#endregion
#region 23번
//static void Main(string[] args)
//{
//    Write(Solution23(1, 1));
//}
//static string Solution23(int a, int b)
//{
//    string answer = string.Empty;
//    DateTime dt;

//    if (DateTime.TryParse(string.Format("24/{0}/{1}", a, b), out dt))
//    {
//        answer = dt.ToString("ddd", new CultureInfo("en-US"));
//    }
//    else
//    {
//        return "입력하신 날짜가 유효하지 않습니다";
//    }

//    return answer;
//}
#endregion
#region 24번
//static void Main()
//{
//    foreach (string item in Solution24(new int[] { 5, 5, 5, 5, 5, 5, 5, 5, 5 }))
//    {
//        WriteLine(item);
//    }

//}
//static string[] Solution24(int[] answers)
//{
//    List<string> answer = new List<string>();
//    string[] name = new string[] { "수포자1", "수포자2", "수포자3" };
//    int[] supoja1 = new int[] { 1, 2, 3, 4, 5 };
//    int[] supoja2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
//    int[] supoja3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
//    int[] answerCounts = new int[3];
//    int highScore = 0;

//    for (int i = 0; i < answers.Length; i++)
//    {
//        if (answers[i] == supoja1[i % 5])
//        {
//            answerCounts[0] += 1;
//        }
//        if (answers[i] == supoja2[i % 8])
//        {
//            answerCounts[1] += 1;
//        }
//        if (answers[i] == supoja3[i % 10])
//        {
//            answerCounts[2] += 1;
//        }

//    }
//    highScore = answerCounts.Max();

//    for (int i = 0; i < 3; i++)
//    {
//        if (highScore == answerCounts[i])
//        {
//            answer.Add(name[i]);
//        }
//    }
//    answer.Sort();

//    return answer.ToArray();

//}
#endregion
#region 25번
//static void Main()
//{
//    WriteLine(Solution25(5, new int[] { 2, 4 }, new int[] { 1, 3, 5 }));
//}

//static int Solution25(int n, int[] lost, int[] reverse)
//{
//    int answer = 0;
//    List<int> reverseList = reverse.ToList();
//    List<int> lostList = lost.ToList();
//    List<int> lendedList = new List<int>();

//    if (2 <= n && n <= 30 && 1 <= lost.Length && lost.Length <= n && 1 <= reverse.Length && reverse.Length <= n)
//    {
//        #region 예외처리
//        for (int i = 0; i < lost.Length; i++)
//        {
//            for (int k = 0; k < reverse.Length; k++)
//            {
//                if (lost[i] == reverse[k]) 
//                {
//                    return 0;
//                }
//            }
//        }
//        #endregion

//        for (int i = 0; i < reverseList.Count; i++)
//        {
//            for (int k = 0; k < lostList.Count; k++)
//            {
//                if (reverseList[i] == lostList[k])
//                {
//                    lendedList.Add(reverseList[i]);
//                }
//            }
//        }

//        foreach (var item in lendedList)
//        {
//            lostList.Remove(item);
//            reverseList.Remove(item);
//        }

//        for (int i = 0; i < lostList.Count; i++)
//        {
//            int bef = lostList[i] - 1;
//            int aft = lostList[i] + 1;

//            foreach (var item in reverseList)
//            {
//                if (item == bef || item == aft)
//                {
//                    reverseList.Remove(item);
//                    answer++;
//                    break;

//                }
//            }
//        }
//    }

//    return n - lostList.Count + answer;
//}
#endregion