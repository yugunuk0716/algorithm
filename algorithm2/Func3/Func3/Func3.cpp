#include <iostream>

using namespace std;
//20214 유건욱의 코드

int mul() 
{
	
}

int main() 
{
	
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



