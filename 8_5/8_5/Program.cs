using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
#region 문제들
//[문제 16] 소수 찾기
//1부터 입력받은 숫자 n 사이에 있는 소수의 개수를 반환하는 함수를 완성하세요.
//소수는 1과 자기 자신으로만 나누어지는 수를 의미합니다. (1은 소수가 아닙니다.)
 
 
//[문제 17] 문자열 다루기 기본
//문자열 s의 길이가 4 혹은 6이고, 숫자로만 구성돼있는지 확인해주는 함수를 완성해주세요.
//예를 들어, s가 “a234”이면 False를 return 하고 “1234”라면 True를 return 하면 됩니다.



//[문제 18] 가운데 글자 가져오기
//단어 s의 가운데 글자를 반환하는 함수를 만들어보세요. 단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.



//[문제 19] 문자열 내림차순으로 배치하기
//문자열 s에 나타나는 문자를 큰 것부터 작은 순으로 정렬해 새로운 문자열을 return하는 함수를 완성해주세요. s는 영문 대소문자로만 구성되어 있으며, 대문자는 소문자보다 작은 것으로 간주합니다.



//[문제 20] 문자열 내 마음대로 정렬하기
//문자열로 구성된 리스트 strings와 정수 n이 주어졌을 때, 각 문자열의 인덱스 n번째 글자를 기준으로 오름차순 정렬하려 합니다. 예를 들어, strings가[“sun”, “bed”, “car”]이고 n이 1이면 각 단어의 인덱스 1의 문자 “u”. “e”, “a”로 strings를 정렬합니다. [“car”, “bed”, “sun”]
#endregion
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
