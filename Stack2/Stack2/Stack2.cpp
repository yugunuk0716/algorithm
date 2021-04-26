//20214 유건욱의 코드
//명재문 도움
#include <iostream>
#include <string>
#include <stack>
#include <vector>
#include <sstream>

using namespace std;

vector<string> vs;
stack<char,vector<char>> num;



int main()
{
    char cal = '+';
    int sum = 0;
    int count = 0;
    int parCount = 0;

    cout << "숫자와 연산자 사이에 꼭 공백 문자를 넣고 식을 입력해 주세요" << endl;
    string ex;
    getline(cin,ex);
    vector<string> vs;
    stringstream ss(ex);

    while(getline(ss,ex,' '))
    {
        vs.push_back(ex);
    }
    for (int i = 0; i < vs.size(); i++) 
    {
        if (vs[i].length() > 1) 
        {
            int a = atoi(vs[i].c_str());
            if (a == 0) 
            {
                cout << "당신이 넣은 것이 숫자가 맞습니까? 만약 숫자가 맞다면 경기게임마이스터고 명재문에게 찾아오세요 ^^1" << endl;
                return 0;
            }
            
                num.push(a);
            
        }
        else if (vs[i].length() == 1) 
        {
            cout << vs[i][0] << endl;
            switch (vs[i][0])
            {
            case '+':
                cal = '+';
                break;
            case '-':
                cal = '-';
                break;
            case '/':
                cal = '/';
                break;
            case '*':
                cal = '*';
                break;
            case '(':
                count++;
                parCount++;
                break;
            case ')':
                count--;
                break;

            default:
                if ('0' <= vs[i][0] && vs[i][0] <= '9') 
                {
                     int b =vs[i][0] - '0';
                     num.push(b);
                }
                else
                {
                    cout << "당신이 넣은 것이 숫자가 맞습니까? 만약 숫자가 맞다면 경기게임마이스터고 명재문에게 찾아오세요 ^^2" << endl;
                    return 0;
                }
                break;
            }
           
        }
        
    }
    if (count != 0)
    {
        cout << "당신이 넣은 것이 숫자가 맞습니까? 만약 숫자가 맞다면 경기게임마이스터고 명재문에게 찾아오세요 ^^3" << endl;
        cout << count;
        return 0;
    }
   

	return 0;
}
#pragma region 맵

//#include <iostream>
//#include <Windows.h>
//#include <stack>
//#include <vector>
//using namespace std;
//
//#define MAZESIZE_X 12
//#define MAZESIZE_Y 22
//#define EXIT_X 11
//#define EXIT_Y 16
//
//typedef struct Position
//{
//	int x;
//	int y;
//	int d;
//}position;
//
//typedef struct Mtable
//{
//	int x;
//	int y;
//}mtable;
//
//int Maze[MAZESIZE_X][MAZESIZE_Y] =
//{
//	{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
//	{1,0,0,0,0,0,0,0,0,0,0,1,0,1,0,1,0,1,0,1,0,1},
//	{1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
//	{1,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1},
//	{1,0,0,1,0,1,0,1,0,0,1,1,1,1,1,0,0,1,1,1,0,1},
//	{1,0,1,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
//	{1,1,0,1,1,1,0,1,0,1,1,1,1,1,1,0,1,1,1,1,1,1},
//	{1,0,0,0,0,0,0,1,0,0,0,1,0,1,0,1,0,1,0,1,0,1},
//	{1,1,1,0,1,1,0,1,1,1,0,1,0,1,0,1,0,1,0,1,0,1},
//	{1,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
//	{1,0,1,0,0,1,0,1,1,1,0,1,0,0,0,1,0,1,0,1,0,1},
//	{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
//};
//Mtable Move[4] =
//{
//	{0,1},
//	{1,0},
//	{-0,1},
//	{-1,0}
//};
//
//int Mark[MAZESIZE_X][MAZESIZE_Y];
//int top;
//Position Trace[(MAZESIZE_X - 2) * (MAZESIZE_Y - 2)];
//
//void ShowMaze(Position);
//void Push(Position);
//void Pop(Position* P);
//int main()
//{
//	int isFound = FALSE;
//	int i, dir;
//
//	Position Now = { 1,1,0 };
//	Position Next;
//
//	Push(Now);
//	while (!isFound && top > 0)
//	{
//		Pop(&Now);
//		dir = Now.d;
//		while (dir < 4)
//		{
//			Next.x = Now.x + Move[dir].x;
//			Next.y = Now.y + Move[dir].y;
//			if (Next.x == EXIT_X && Next.y == EXIT_Y)
//			{
//				Next.d = dir;
//				Push(Next);
//				isFound = TRUE;
//				break;
//			}
//			else if ((Maze[Next.x][Next.y] == 0) && (Mark[Next.x][Next.y] == 0))
//			{
//				Now.d = ++dir;
//				Push(Now);
//				Now.x = Next.x;
//				Now.y = Next.y;
//				dir = 0;
//				Mark[Next.x][Next.y];
//
//			}
//			else
//			{
//				dir++;
//			}
//			ShowMaze(Now);
//		}
//	}
//	if (isFound == TRUE)
//	{
//		for (i = 0; i < top; i++)
//		{
//			ShowMaze(Trace[i]);
//		}
//	}
//	else
//	{
//		cout << "못찾음" << endl;
//	}
//	system("pause");
//
//
//
//	return 0;
//}
//
//void ShowMaze(Position P)
//{
//	int i, j;
//	Sleep(50);
//	system("cls");
//	cout << "출구는 (11,16)" << endl;
//	cout << "현재 좌표는" << P.x << " " << P.y << " " << P.d << endl;
//	for (i = 0; i < MAZESIZE_X; i++)
//	{
//		for (j = 0; j < MAZESIZE_Y; j++)
//		{
//			if (Maze[i][j] == 1)
//				cout << "#";
//			else if (P.x == i && P.y == j)
//				cout << "&";
//			else
//				cout << " ";
//		}
//		cout << endl;
//	}
//}
//
//void Push(Position P)
//{
//	Trace[top].x = P.x;
//	Trace[top].y = P.y;
//	Trace[top].d = P.d;
//	top++;
//}
//
//void Pop(Position* P)
//{
//	top--;
//	P->x = Trace[top].x;
//	P->y = Trace[top].y;
//	P->d = Trace[top].d;
//}
#pragma endregion
#pragma region 천단위 콤마
//int input = 0;
//cin >> input;
//
//while (input > 0)
//{
//    if (num.size() % 4 != 3)
//    {
//        num.push(input % 10 + 48);
//        input /= 10;
//    }
//    else if (num.size() % 4 == 3)
//    {
//        num.push(',');
//    }
//}
//while (num.size() > 0)
//{
//    char output = num.top();
//    cout << output;
//    num.pop();
//}
//return 0;
//}
#pragma endregion


