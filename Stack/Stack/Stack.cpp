//20214 유건욱의 코드
//#include <iostream>
//#include <string>
//#include <stack>
//#include <sstream>
//
//using namespace std;
//
//struct oper {
//    int p; 
//    string o; 
//};
//
//stack<int> num;
//stack<oper> op;
//
//void calc() {
//    int a, b, result;
//    b = num.top();
//    num.pop();
//    a = num.top();
//    num.pop();
//    string oper = op.top().o;
//    op.pop();
//
//    if (oper == "*")
//        result = a * b;
//    else if (oper == "/")
//        result = a / b;
//    else if (oper == "+")
//        result = a + b;
//    else if (oper == "-")
//        result = a - b;
//    num.push(result);
//}
//
//int main() {
//    ios::sync_with_stdio(false);
//    cin.tie(NULL);
//    cout.tie(NULL);
//
//    string input = "12 + 12 * ( 1 - 8 ) / 2";
//    stringstream ss(input);
//
//   
//    string tok;
//    while (ss >> tok) {
//        if (tok == "(") {
//            op.push({ 0, tok });
//        } 
//        else if (tok == ")") {
//            while (op.top().o != "(")
//                calc();
//            op.pop();
//        }
//        else if (tok == "*" || tok == "/" || tok == "+" || tok == "-") {
//            int prior; 
//            if (tok == "*")
//                prior = 2;
//            else if (tok == "/")
//                prior = 2;
//            else if (tok == "+")
//                prior = 1;
//            else if (tok == "-")
//                prior = 1;
//
//            while (!op.empty() && prior <= op.top().p)
//                calc();
//            op.push({ prior, tok });
//        }
//        else 
//            num.push(stoi(tok));
//    }
//    while (!op.empty())
//        calc();
//
//    cout << num.top();
//
//    return 0;
//}



	
	




#pragma region Stack
//#include <iostream>
//using namespace std;
//#define SIZE 10
//
//typedef struct
//{
//    char stackArr[SIZE];
//    int topIndex;
//    char name;
//} stack;
//typedef stack* pstack;
//void init(pstack ps, char c);
//
//void push(pstack ps, char c);
//
//char pop(pstack ps);
//
//int main()
//{
//    stack s1, s2;
//    int i;
//
//    init(&s1, 'A');
//    init(&s2, 'B');
//    cout << endl;
//
//    push(&s1, 'd');
//    push(&s1, 'a');
//    push(&s1, 't');
//    push(&s1, 'a');
//    push(&s2, 's');
//    push(&s2, 't');
//    push(&s2, 'a');
//    push(&s2, 'c');
//    push(&s2, 'k');
//
//    for (i = 0; i < 5; i++)
//    {
//        cout << "Pop s1: " << pop(&s1) << endl;
//    }
//    cout << endl;
//
//    for (i = 0; i < 5; i++)
//    {
//        cout << "Pop s2: " << pop(&s2) << endl;
//    }
//    cout << endl;
//
//    return 0;
//}
//
//void init(pstack ps, char c)
//{
//    ps->topIndex = 0;
//    ps->name = c;
//    cout << "Constructing stack" << ps->name << endl;
//}
//
//void push(pstack ps, char ch)
//{
//    if (ps->topIndex == SIZE)
//    {
//        //스택이 full 상태
//        cout << "Stack" << ps->name << "is full" << endl;
//        return;
//    }
//    ps->stackArr[ps->topIndex] = ch;
//    ps->topIndex++;
//}
//
////top이 0이면 bottom return 0
//char pop(pstack ps)
//{
//    if (ps->topIndex == 0)
//    {
//        cout << "Stack" << ps->name << "is empty" << endl;
//        return 0;
//    }
//    ps->topIndex--;
//
//    return ps->stackArr[ps->topIndex];
//}
#pragma endregion

#pragma region 역출력 stack
//#include <iostream>
//#include <stack>
//#include <vector>
//using namespace std;
//
//
//stack<int, vector<int>> example;
//
//int main()
//{
//	int a = 0;
//	int b = 0;
//	int c = 0;
//
//	cin >> a >> b >> c;
//
//	example.push(a);
//	example.push(b);
//	example.push(c);
//
//
//	for (int i = 0; i < 3; i++)
//	{
//		int result = example.top();
//		cout << result << endl;
//		example.pop();
//	}
//	return 0;
//
//}
#pragma endregion
#pragma region 숫자 역출력
//#include <iostream>
//#include <stack>
//#include <vector>
//using namespace std;
//
//
//stack<int, vector<int>> example;
//
//
//int main()
//{
//	string s = " ";
//	cout << "숫.자.만 입력 하세요 ^^" << endl;
//	cin >> s;
//	for (int i = 0; i < s.size(); i++)
//	{
//		if (example.empty())
//		{
//			cout << "스택이 비어있으니 돌아가세요" << endl;
//		}
//		if (0 < s[i] - '0' && s[i] - '0' < 9)
//		{
//			example.push(s[i]);
//		}
//		else
//		{
//			return 0;
//		}
//
//
//	}
//
//	for (int i = 0; i < s.size(); i++)
//	{
//		char result = example.top();
//		example.pop();
//		cout << result;
//	}
//	cout << endl;
//	return 0;
//
//}
#pragma endregion
//stack<int,vector<int>> example;

#pragma region 스택 맵
#include <iostream>
#include <Windows.h>
#include <stack>
#include <vector>
using namespace std;
//20214 유건욱의 코드

#define MAZESIZE_X 12
#define MAZESIZE_Y 22
#define EXIT_X 11
#define EXIT_Y 16

typedef struct Position
{
	int x;
	int y;
	int d;
}position;

typedef struct Mtable
{
	int x;
	int y;
}mtable;

int Maze[MAZESIZE_X][MAZESIZE_Y] =
{
	{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
	{1,0,0,0,0,0,0,0,0,0,0,1,0,1,0,1,0,1,0,1,0,1},
	{1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
	{1,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1},
	{1,0,0,1,0,1,0,1,0,0,1,1,1,1,1,0,0,1,1,1,0,1},
	{1,0,1,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
	{1,1,0,1,1,1,0,1,0,1,1,1,1,1,1,0,1,1,1,1,1,1},
	{1,0,0,0,0,0,0,1,0,0,0,1,0,1,0,1,0,1,0,1,0,1},
	{1,1,1,0,1,1,0,1,1,1,0,1,0,1,0,1,0,1,0,1,0,1},
	{1,0,0,0,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
	{1,0,1,0,0,1,0,1,1,1,0,1,0,0,0,1,0,1,0,1,0,1},
	{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}
};
Mtable Move[4] =
{
	{0,1},
	{1,0},
	{-0,1},
	{-1,0}
};

int Mark[MAZESIZE_X][MAZESIZE_Y];
int top;
Position Trace[(MAZESIZE_X - 2) * (MAZESIZE_Y - 2)];

void ShowMaze(Position);
void Push(Position);
void Pop(Position* P);

int main(void)
{
	int isFound = FALSE;
	int i, dir;

	Position Now = { 1,1,0 };
	Position Next;

	Push(Now);

	while (!isFound && top > 0)
	{
		Pop(&Now);
		dir = Now.d;
		while (dir < 4)
		{
			Next.x = Now.x + Move[dir].x;
			Next.y = Now.y + Move[dir].y;
			if (Next.x == EXIT_X && Next.y == EXIT_X)
			{
				Next.d = dir;
				Push(Next);
				isFound = TRUE;
				break;
			}
			else if ((Maze[Next.x][Next.y]) == 0 && (Mark[Next.x][Next.y] == 0))
			{
				Now.d = ++dir;
				Push(Now);

				Now.x = Next.x;
				Now.y = Next.y;
				dir = 0;

				Mark[Next.x][Next.y] = 1;
			}
			else dir++;

			ShowMaze(Now);

		}
	}
	if (isFound == TRUE)
	{
		for (i = 0; i < top; i++)
			ShowMaze(Trace[i]);
	}
	else cout << "Not Found!" << endl;
	system("pause");


	return 0;

}
void ShowMaze(Position P)
{
	int i, j;
	Sleep(50);
	system("cls");
	cout << "출구는 (11,16)" << endl;
	cout << "현재 좌표는" << P.x << "" << P.y << "" << P.d << endl;
	for (i = 0; i < MAZESIZE_X; i++)
	{
		for (j = 0; j < MAZESIZE_Y; j++)
		{
			if (Maze[i][j] == 1)
				cout << "#" << endl;
			else if (P.x == i && P.y == j)
				cout << "&";
			else
				cout << " ";
		}

	}
	cout << endl;


}
void Push(Position P)
{
	Trace[top].x = P.x;
	Trace[top].y = P.y;
	Trace[top].d = P.d;
	top++;
}

void Pop(Position* P)
{
	top--;
	P->x = Trace[top].x;
	P->y = Trace[top].y;
	P->d = Trace[top].d;

}
#pragma endregion