#include <iostream>

using namespace std;

void hanoi(int n, char f, char b, char t) 
{
	if (n == 1) 
	{
		cout << "원반 1을" << f << "에서" << t << "로 이동" << endl;
		
	}
	else
	{
		hanoi(n - 1, f, t, b);
		cout << "원반" << n << "을" << f << "에서" << t << "로 이동" << endl;
		hanoi(n - 1, b, f, t);
		
	}
		
}

int main()
{
	int cNum = 0;
	cin >> cNum;
	hanoi(cNum, 'A', 'B', 'C');

	return 0;
	
}
	



#pragma region 주민번호
/*char id[14];
int year;
int born = 0;
cout << "주민번호 입력하세여 ^^" << endl;
cin >> id;
if (id[6] % 2 == 1)
{
	cout << "남자입니다" << endl;
}
else
{
	cout << "여자입니다" << endl;
}
year = (id[0] - 48) * 10 + (id[1] - '0');
year += id[6] <= '2' ? 1900 : 2000;
cout << "출생 연도: " << year << endl;
cout << "나이 " << 2021 - year + 1 << endl;
born = (id[7] - 48) * 10 + (id[8] - '0');
cout << born << endl;
if (born < 9
	)
{
	cout << "출생지: 서울" << endl;
}
else if (born < 13)
{
	cout << "출생지: 부산" << endl;
}
else if (born < 15)
{
	cout << "출생지: 인천" << endl;
}
else if (born < 18)
{
	cout << "출생지: 경기 주요 도시 " << endl;
}
else if (born < 25)
{
	cout << "출생지: 경기도 도시" << endl;
}
else if (born < 34)
{
	cout << "출생지: 강원도 " << endl;
}
else if (born < 39)
{
	cout << "츨생지: 충청북도" << endl;
}
else if (born < 47)
{
	cout << "출생지: 충청남도" << endl;
}
else if (born < 54)
{
	cout << "출생지: 전라북도 " << endl;
}
else if (born < 66)
{
	cout << "출생지: 전라남도" << endl;
}
else
{
	cout << "출생지: 경상도" << endl;
}

int a =id[0] * 2;
int b =id[1] * 3;
int c =id[2] * 4;
int d =id[3] * 5;
int e =id[4] * 6;
int f =id[5] * 7;
int g =id[6] * 8;
int h =id[7] * 9;
int i =id[8] * 2;
int j =id[9] * 3;
int k =id[10] * 4;
int l =id[11] * 5;

int m = (12 - ((a + b + c + d + e + f + g + h + i + j + k + l) % 11)) % 10;

if (m == id[12]-'0')
{
	cout << "유효" << endl;
}
else
{
	cout << m << endl;
	cout << "유효하지 않음" << endl;
}
return 0;*/
#pragma endregion
#pragma region 파스칼
//int a[10][10] = { 0, };
//int i, j;
//
//for (i = 0; i < 10; i++)
//{
//	a[i][0] = 1;
//}
//
//for (i = 0; i < 10; i++)
//{
//	for (j = 0; j < 10; j++)
//	{
//		if (j > 0 && i > 0)
//		{
//			a[i][j] = a[i - 1][j] + a[i - 1][j - 1];
//
//		}
//		if (a[i][j] > 0)
//		{
//			cout << a[i][j] << " ";
//		}
//	}
//	cout << endl;
//}


#pragma endregion
#pragma region 다차원 배열 역출력
/*char arr1[10][10] = { 0, };
	char arr2[10][10] = { 0, };
	char arr3[10][10] = { 0, };
	int i;
	int count;
	int total;

	int stored = 0;
	double waste;

	total = sizeof(arr1);
	count = sizeof(arr1) / sizeof(arr1[0]);

	for (i = 0; i < count; i++)
	{
		cin >> arr1[i];


	}
	for (int j = 0; j < count; j++)
	{
		cin >> arr2[j];


	}
	for (int n = 0; n < count; n++)
	{
		cin >> arr3[n];


	}


	for (total; total > 0; total--)
	{
		if (total > 10)
		{
			total = 8;
		}
		cout << arr1[total][total] ;
	}


	return 0;*/

#pragma endregion
#pragma region 팩토리얼
//int Facto(int n)
//{
//	if (n == 0)
//	{
//		return 1;
//	}
//	else
//	{
//		return(n * Facto(n - 1));
//	}
//	int n;
//	cin >> n;
//	cout << "1부터 " << n << " 까지의 곱은" << Facto(n) << "입니다" << endl;
//}
#pragma endregion
#pragma region 피보나치 수열
//int Fib(int n)
//{
//	if (n == 1 || n == 2)
//		return 1;
//	else
//		return Fib(n - 1) + Fib(n - 2);
//}
//
//int main()
//{
//	// 20214 유건욱의 코트
//	int i;
//	for (i = 1; i <= 15; i++)
//	{
//		cout << Fib(i) << endl;
//	}
//	return(0);
#pragma endregion
#pragma region 가우스
//#include <iostream>
//
//using namespace std;
//
//int Gaus(int g)
//{
//	static int count = 0;
//	static int sum = 0;
//
//	sum += 1 + g;
//	if (count < g - 1)
//	{
//		count++;
//		Gaus(g);
//	}
//	else
//	{
//		return sum / 2;
//	}
//}
//
//int main()
//{
//	// 20214 유건욱의 코트
//	int i;
//	cin >> i;
//	cout << Gaus(i);
//
//	return(0);
//}
#pragma endregion
#pragma region 가우스 재귀함수 아님
//#include <iostream>
//
//using namespace std;
//
//
//int main()
//{
//	int i = 0;
//	int sum = 0;
//	int num = 0;
//	cin >> num;
//	for (i = 0; i <= num; i++)
//	{
//		sum += i;
//	}
//	cout << sum;
//}
#pragma endregion
#pragma region 팩토리얼 재귀함수 아님
//#include <iostream>
//
//using namespace std;
//
//
//int main()
//{
//	int i = 0;
//	int sum = 1;
//	int num = 1;
//	cin >> num;
//	for (i = 1; i <= num; i++)
//	{
//		sum *= i;
//	}
//	cout << sum;
//	return 0;
//}
#pragma endregion
#pragma region 가우스 없는 가우스 팀
//#include <iostream>
//
//using namespace std;
//
//int Gaus(int g)
//{
//	if (g == 1)
//	{
//		return 1;
//	}
//	else
//	{
//		return Gaus(g - 1) + g;
//	}
//
//}
//
//int main()
//{
//	// 20214 유건욱의 코트
//	int i;
//	cin >> i;
//	cout << Gaus(i);
//
//	return(0);
//}
#pragma endregion
#pragma region 역순
//#include <iostream>
//#include <string>
//#include <algorithm>
//
//using namespace std;
//
//int rev(int n)
//{
//	if (n == 0)
//		return 1;
//	else
//	{
//		string s = to_string(n);
//		reverse(s.begin(), s.end());
//		return atoi(s.c_str());
//	}
//
//}
//
//int main()
//{
//	int n;
//	cin >> n;
//	cout << rev(n) << endl;
//
//}
#pragma endregion
