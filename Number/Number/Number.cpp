﻿#include <iostream>
using namespace std;

int main() {
	// 20214 유건욱의 코트
	char id[14];
	int year;
	int born = 0;
	cout << "주민번호 입력하세여 ^^" << endl;
	cin >> id;
	if (id[6] % 2 == 1)
	{
		cout << "남자입니다" << endl;
	}
	else if(id[6]% 2 ==0)
	{
		cout << "여자입니다" << endl;
	}
	else
	{
		cout << "잘못된 입력이거나 외국인이거나 1800년대 생이십니다 ^^" << endl;
	}

	year = (id[0] - 48) * 10 + (id[1] - '0');
	year += id[6] <= '2' ? 1900 : 2000;
	cout << "출생 연도: " << year << endl;
	cout << "나이 " << 2021 - year + 1 << endl;
	born = (id[7] - 48) * 10 + (id[8] - '0');
	cout << born << endl;
	if (born < 9)
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
	else if(born < 91)
	{
		cout << "출생지: 경상도" << endl;
	}
	else
	{
		cout << "어디 사세요?" << endl;
	}

	int a = id[0] * 2;
	int b = id[1] * 3;
	int c = id[2] * 4;
	int d = id[3] * 5;
	int e = id[4] * 6;
	int f = id[5] * 7;
	int g = id[6] * 8;
	int h = id[7] * 9;
	int i = id[8] * 2;
	int j = id[9] * 3;
	int k = id[10] * 4;
	int l = id[11] * 5;

	int m = (12 - ((a + b + c + d + e + f + g + h + i + j + k + l) % 11)) % 10;

	if (m == id[12]- '0')
	{
		cout << "유효" << endl;
	}
	else
	{
		cout << m << endl;
		cout << "유효하지 않음" << endl;
	}
	return 0;

}