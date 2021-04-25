//20214유건욱
#include <iostream>
#include <stdio.h>
#include <stdlib.h>
using namespace std;

int count = 0;
int n;
int front = 0, rear = 0;
int* queue;

void enQueue(int data) {

	if ((rear + 1) % (n + 1) == front) {
		cout << "큐가 꽉 찼습니다." << endl;
		return;
	}

	rear = (rear + 1) % (n + 1);
	queue[rear % (n + 1)] = data;

}

int deQueue() {
	int data;

	if (front == rear) {
		cout << "큐가 비었습니다." << endl;
		return 0;
	}

	data = queue[(front + 1) % (n + 1)];
	front = (front + 1) % (n + 1);
}

void printQueue() {
	int idx = 0;
	idx = (front + 1) % (n + 1);

	do {
		if (front == rear) {
			cout << "큐가 비었습니다." << endl;
			break;
		}
		else if (idx > rear)
			break;
		cout << queue[idx++ % (n + 1)] << endl;
	} while (1);

}

int main() {

	cout << "원형 큐의 크기 입력 : ";
	cin >>  n;
	queue = (int*)malloc(sizeof(int) * (n + 1));

	while (1) {
		int menu, data;
		printf("\n1. 삽입 , 2. 삭제, 3. 출력, 4. 종료\n");
		cin >> menu;

		switch (menu)
		{
		case 1:
			cout << "삽입할 데이터 입력 : ";
			cin >> data;
			enQueue(data);
			break;
		case 2:
			deQueue();
			break;
		case 3:
			printQueue();
			break;
		case 4:
			exit(1);
			break;
		}
	}

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



