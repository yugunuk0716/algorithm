//20214 유건욱의 코드
//명재문, 김민준 도움
#include <iostream>
#include <string>
#include <stack>
#include <vector>
#include <sstream>
#include <string>

using namespace std;

vector<string> vs;
stack<int,vector<int>> num;
stack<int, vector<int>> startpar;
stack<int, vector<int>> endpar;
int scount = 0;
int parCount;
int startParCal = 0;
int endParCal = 0;
char cal = '+';
int sum = 0;

int ParCal(int first , int end) 
{
 
    int temp = 0;
   
    sum = 0;
    for (int i = first; i < end; i++)
    {

        if (vs[i].length() > 1)
        {
            int t = atoi(vs[i].c_str());
            if (t == 0)
            {
                cout << "당신이 넣은 것이 숫자가 맞습니까? 만약 숫자가 맞다면 경기게임마이스터고 명재문에게 찾아오세요 ^^1" << endl;
                return 0;
            }


            switch (cal)
            {
            case '+':
                num.push(t);
                break;
            case '-':
                num.push(-t);
                break;
            case '*':
                temp = num.top() * t;
                num.pop();
                num.push(temp);

                break;
            case '/':
                temp = num.top() / t;
                num.pop();
                num.push(temp);
            default:
                break;
            }
        }
        else if (vs[i].length() == 1)
        {
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
                scount++;
                if (scount > 1) 
                {
                    cout << "문제에서 괄호는 한쌍만 주어진 다 그러셨습니다!" << endl;
                    return 0;
                }
                //parCount++;
                break;
            case ')':
                scount--;
                break;

            default:
                if ('0' <= vs[i][0] && vs[i][0] <= '9')
                {
                    int b = vs[i][0] - '0';

                    switch (cal)
                    {
                    case '+':
                        num.push(b);
                        break;
                    case '-':
                        num.push(-b);
                        break;
                    case '*':
                        temp = num.top() * b;
                        num.pop();
                        num.push(temp);

                        break;
                    case '/':
                        temp = num.top() / b;
                        num.pop();
                        num.push(temp);
                    default:
                        break;
                    }
                }
                else if (vs[i][0] == ' ') 
                {
                    continue;
                }
                else
                {
                    cout << "당신이 넣은 것이 숫자가 맞습니까? 만약 숫자가 맞다면 경기게임마이스터고 명재문에게 찾아오세요 ^^2" << endl;
                    return 0 ;
                }
                break;
            }
            
        }
        

    }
    int forNum = num.size();
    
    for (int i = 0; i < forNum; i++)
    {
        cout <<"계산 전" <<  sum << endl;
        sum += num.top();
        cout <<"계산 후" << sum << endl;
        num.pop();
    }
    vs[startParCal][0] = sum;
    startParCal += 1;

    cout << "괄호 안" << sum << endl;
    return sum;
}





int main()
{
    int result = 0;
    parCount = 0;
    
    cout << "숫자와 연산자 사이에 꼭 공백 문자를 넣고 식을 입력해 주세요" << endl;
    cout << "ex) 1 + 2 * ( 3 + 2 )" << endl;
    string ex;
    getline(cin,ex);
    stringstream ss(ex);

    while(getline(ss,ex,' '))
    {
        vs.push_back(ex);
    }
    for (int i = 0; i < vs.size(); i++)
    {
        if (vs[i][0] == '(') 
        {
            parCount++;
        }

    }
    
    
    for ( startParCal = 0; startParCal < vs.size(); startParCal++)
    {
        if (vs[startParCal][0] == '(')
        {
            startpar.push(startParCal);
        }
        
        if (startpar.size() == parCount) 
            break;
        
    }
    
    for ( endParCal = vs.size() - 1; endParCal  > 0;  endParCal--)
    {
       
        if (vs[endParCal][0] == ')')
        {
            endpar.push(endParCal);
        }
        
        if (endpar.size() == parCount)
            break;
    }
    
    for (int i = 0; i < parCount; i++)
    {
        cout << "괄호 안" << endl;
        result = ParCal(startpar.top(), endpar.top());
       
        for (int n = startpar.top(); n <= endpar.top(); n++)
        {
            vs[n] = ' ';
        }
        vs[startpar.top()] = to_string(result);
        while (true)
        {
            startpar.top()++;
            endpar.top()++;

            if (endpar.top() == vs.size())
            {
                break;
            }

            if (scount > 1) 
            {
                vs[startpar.top()] = vs[endpar.top()];
                vs[endpar.top()] = ' ';
            }
            else
            {
                cout << "문제에서 괄호는 한쌍만 주어진 다고 그러셨습니다!" << endl;
                return 0;
            }
        }
        
        startpar.pop();
        endpar.pop();
    }
    
    cout << "결과 값 : " << ParCal(0, vs.size());
    
    
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


