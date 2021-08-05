using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _8_5
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        #region 16번
        static int Solution16(int n)
        {
            int count = 0;
            int numCount;

            for (int i = 1; i < n; i++)
            {
                numCount = 0;

                for (int k = 1; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        numCount++;

                    }

                }
                if (numCount == 1)
                {
                    count++;
                }
            }

            return count;
        }
        #endregion
        #region 17번
        static bool Solution17(string s)
        {
            int i = 0;
            bool result = false;

            if (s.Length == 4 || s.Length == 6)
            {
                result = int.TryParse(s, out i);
            }

            return result;
        }
        #endregion
        #region 18번
        static string Solution18(string s)
        {
            return s.Length % 2 == 0 ? s[s.Length / 2 - 1].ToString() + s[s.Length / 2].ToString() : s[s.Length / 2].ToString();
        }
        #endregion
        #region 19번
        static string Solution19(string s)
        {
            List<char> chList = s.ToList();
            chList.Sort((x, y) => y.CompareTo(x));
            string answer = string.Empty;

            foreach (var item in chList)
            {
                answer += item;
            }

            return answer;
        }
        #endregion
        #region 20번
        static List<string> Solution20(List<string> strings, int n)
        {
            strings.Sort((str1, str2) =>
            {
                string s1 = str1.Substring(n, 1);
                string s2 = str2.Substring(n, 1);

                return s1 == s2 ? str1.CompareTo(str2) : s1.CompareTo(s2);

            });


            return strings;
        }
        #endregion
    }
}
