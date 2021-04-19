//20214유건욱
#include <iostream>
using namespace std;


#define NEXT(index,QSIZE) ((index+1)%QSIZE)

typedef struct Queue 
{
	int* buf;
	int qsize;
	int front;
	int rear;
	int count;

}Queue;

void InitQueue(Queue* queue, int qsize);
int IsFull(Queue* queue);
int Empty(Queue*queue);
void Enqueue(Queue*queue,int data);
int Dequeue(Queue* queue);

int main(void)
{
	int i, size;
	int select = -1;


	Queue queue;

	cout << "큐의 크기 입력 : ";
	cin >> size;

	InitQueue(&queue, size);
	while (true)
	{
		cout <<"1. Enqueue  2.Dequeue"
	}

	
	
	return 0;
}

#pragma region 큐 구현
//20214유건욱
//#include <iostream>
//#include <queue>
//using namespace std;
//
//queue<int> q;
//
//int main()
//{
//	int i;
//
//
//	for (int i = 1; i <= 5; i++)
//	{
//		cout << i << "입력" << endl;
//		q.push(i);
//		q.front();
//	}
//	cout << endl;
//	while (!q.empty())
//	{
//		if (q.empty())
//		{
//			cout << "큐가 비었음!" << endl;
//
//		}
//
//		cout << q.front() << "출력" << endl;
//
//		q.pop();
//	}
//	cout << endl;
//	return 0;
//}
#pragma endregion
#pragma region 규 입력및 삭제
//20214유건욱
//#include <iostream>
//#include <queue>
//using namespace std;
//
//queue<int> q;
//
//int main()
//{
//	int select = -1;
//	q = queue<int>();
//
//	while (1)
//	{
//		cout << "1.Enqueue   2.Dequeue" << endl;
//		cout << ">>";
//		cin >> select;
//
//		switch (select)
//		{
//		case 1:
//			int value;
//			cout << "input data";
//			cin >> value;
//			q.push(value);
//			break;
//		case 2:
//			if (!q.empty())
//			{
//				q.pop();
//
//			}
//			else
//			{
//				cout << "Dequeue를 실행할 값이 없습니다" << endl;
//
//			}
//			break;
//		default:
//			break;
//		}
//	}
//
//
//
//
//	return 0;
//}

#pragma endregion



