#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <iostream>

const int REPEATED = 36000;

int main(void) {
    int i, arr[11] = { 0, };

    srand(time(NULL));
    for (i = 1; i <= REPEATED; i++) {
        arr[rand() % 6 + rand() % 6]++;
    }

    printf("Output : \n\n");
    for (i = 0; i < 11; i++) {
        printf("%2d : %4d (%f)\n", 2 + i, arr[i], (float)arr[i] / REPEATED);
    }

    return 0;
}




#pragma region 최댓값 출력
//#include <iostream>
//#define MAX_SIZE 5
//using namespace std;
////20214 유건욱의 코드
//
//void GetNumbers(int number[MAX_SIZE]);
//int Max(int number[], int i, int last);
//int MaxPos(int number[], int i, int last);
//void PrintArray(int number[], int resultIndex, int resultNumber);
//
//int main()
//{
//	int number[MAX_SIZE] = { 0 };
//	int counter = 0;
//
//	int resultNumber = 0;
//	int resultIndex = 0;
//
//
//	GetNumbers(number);
//
//	resultNumber = Max(number, 0, MAX_SIZE);
//
//	resultIndex = MaxPos(number, 0, MAX_SIZE);
//
//	PrintArray(number, resultIndex, resultNumber);
//
//	return 0;
//}
//
//void GetNumbers(int number[MAX_SIZE])
//{
//	int counter = 0;
//	int numberInput = 0;
//	int loop = 1;
//
//	while (counter < MAX_SIZE)
//	{
//		loop = 1;
//
//		while (loop == 1)
//		{
//			cout << "배열에 저장할 " << counter + 1 << " 번째 정수를 입력하시오" << endl;
//			fflush(stdin);
//
//			cin >> numberInput;
//
//			if (numberInput >= 0)
//			{
//				number[counter] = numberInput;
//				++counter;	loop = 0;
//			}
//			else
//			{
//				cout << "값은 0 이상이여야 됨" << endl;
//				loop = 1;
//			}
//		}
//
//	}
//}
//int Max(int number[], int i, int last)
//{
//	if (i < last)
//	{
//		int MaxN = Max(number, i + 1, last);
//
//		if (number[i] >= MaxN)
//		{
//			return (number[i]);
//		}
//		else
//		{
//			return (MaxN);
//		}
//	}
//
//	else
//	{
//		return(number[i]);
//	}
//}
//int MaxPos(int number[], int i, int last)
//{
//	if (i < last)
//	{
//		int j = MaxPos(number, i + 1, last);
//
//
//		if (number[i] >= number[j])
//		{
//			return(i);
//		}
//		else
//		{
//			return(j);
//		}
//	}
//	else
//	{
//		return(i);
//	}
//
//}
//void PrintArray(int number[], int resultIndex, int resultNumber)
//{
//	int counter = 0;
//
//	cout << "현재 배열에 저장된 값" << endl;
//
//	while (counter < MAX_SIZE)
//	{
//		cout << number[counter] << endl;
//		++counter;
//	}
//	cout << "최댓값은 " << resultNumber << "이다" << endl;
//}
#pragma endregion

#pragma region 구구단 재귀함수
//#include <iostream>
//
//using namespace std;
////20214 유건욱의 코드
//
//int mul(int num1, int num2)
//{
//	if (num1 <= 9)
//	{
//		cout << num1 << "X" << num2 << "=" << num1 * num2 << endl;
//		if (num2 < 9)
//			return mul(num1, num2 + 1);
//		else
//		{
//			return mul(num1 + 1, 1);
//		}
//
//	}
//	else if (num1 > 9)
//	{
//
//		return num1 * num2;
//	}
//}
//
//int main()
//{
//	int i = 2;
//	int j = 1;
//	cout << mul(i, j) << endl;
//}
#pragma endregion

#pragma region 자리수 합
//#include <iostream>
//using namespace std;
////20214 유건욱
//int s;
//int plusFunc(int i)
//{
//	int c;
//	if (i < 10)
//	{
//		c = i;
//		s += i;
//		return s;
//	}
//	else
//	{
//		c = i % 10;
//		s += c;
//		return plusFunc(i / 10);
//	}
//}
//
//int main()
//{
//	int n = 0;
//	cin >> n;
//	cout << plusFunc(n);
//
//	return 0;
//}
#pragma endregion


#pragma region 역순 출력 재귀함수
//#include <iostream>
//using namespace std;
////20214 유건욱
//int s;
//int printFunc(int i)
//{
//
//	cout << i << endl;
//	if (i == 2)
//		return 1;
//	else
//	{
//		return printFunc(i - 1);
//	}
//}
//
//int main()
//{
//	int n = 0;
//	cin >> n;
//	cout << printFunc(n);
//	return 0;
//}
#pragma endregion


#pragma region 짝수만 출력
#include <iostream>
//using namespace std;
////20214 유건욱
//int Even(int a, int b)
//{
//	if (a <= b)
//	{
//		if (a % 2 == 0)
//			cout << a << endl;
//		return Even(a + 1, b);
//	}
//
//}
//
//
//int main()
//{
//	int a, b;
//	cin >> a;
//	cin >> b;
//	Even(a, b);
//}
#pragma endregion

