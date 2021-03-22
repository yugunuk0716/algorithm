#include <iostream>
#include <stdio.h>
#include <algorithm>
#include <string.h>
#define COLUMN 7 
#define ROW 5
using namespace std;
int main() 
{
	// 20214 유건욱의 코트
	char arr[ROW][COLUMN] = { 0, };
	int row,col;
	int cnt = 1;

	for (row = 0; row < ROW; row++) 
	{
		for (col = 0; col < COLUMN; col++)
		{
			cin >> arr[row][col];

		}
		
	}
	
	
	
	
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
