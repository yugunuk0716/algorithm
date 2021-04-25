//20214유건욱 코드
#include <iostream>
using namespace std;

struct Node
{
	int data;
	struct Node* nextNode;
	struct Node* prevNode;
};
struct Node* CreateNode(int data) 
{
	Node* temp = new Node;
	temp->data = data;
	temp->nextNode = NULL;
	temp->prevNode = NULL;
	return temp;
}
void AppendNode(Node** head, Node* newNode) 
{
	if(*head == NULL)
	{
		*head = newNode;
	}
	else
	{
		Node* tail = *head;
		while (tail->nextNode != NULL)
		{
			tail = tail->nextNode;
		}
		tail->nextNode = newNode;
		newNode->prevNode = tail;
		newNode->nextNode = NULL;
	}
}
int CountNode(Node** head) 
{
	int count = 0;
	struct Node* current = *head;
	while (current != NULL)
	{
		current = current->nextNode;
		count++;
	}
	return count;
}
struct Node* SearchNode(Node** head, int index)
{
	struct Node* current = *head;
	while (current->nextNode != NULL && (--index) >=0)
	{
		current = current->nextNode;
	}
	return current;
	
};
void RemoveNode(Node** head, Node* remove) 
{
	if (*head == NULL) 
	{
		cout << "There is no list data" << endl;
		*head = remove->nextNode;
		remove->nextNode = NULL;
		remove->prevNode = NULL;
		delete(remove);
	}
	else
	{
		Node* temp = *head;
		while (temp->nextNode !=remove)
		{
			temp = temp->nextNode;
		}
		temp->nextNode = remove->nextNode;
		remove->nextNode->prevNode = temp;
		remove->nextNode = NULL;
		remove->prevNode = NULL;
		delete(remove);
	}
}
void InsertNodeAfter(Node*current, Node*newNode)
{
	newNode->prevNode = current;
	newNode->nextNode = current->nextNode;
	current->nextNode->prevNode = newNode;
	current->nextNode = newNode;
}
void InsertNodeBefore(Node* current, Node* newNode)
{
	newNode->prevNode = current->prevNode;
	newNode->nextNode = current;
	current->prevNode->nextNode = newNode;
}
int main() 
{
	Node* node = NULL;
	Node* head = NULL;
	Node* mynode = NULL;

	int i = 0;
	int count = 0;
	for ( i = 0; i < 10; i++)
	{
		node = CreateNode(i);
		AppendNode(&head, node);
	}
	cout << "counting node" << endl;
	count = CountNode(&head);
	cout << count << endl;
	cout << "Checking Node" << endl;
	for ( i = 0; i < count; i++)
	{
		mynode = SearchNode(&head, i);
		cout << "[" << i << "]" << mynode->data << endl;
	}
	cout << "inserting after node" << endl;
	node = CreateNode(3000);
	mynode = SearchNode(&head,6);
	InsertNodeAfter(mynode,node);

	count = CountNode(&head);

	for ( i = 0; i < count; i++)
	{
		mynode = SearchNode(&head,i);
		printf("[%d]%d\n",i,mynode->data);

	}
	cout << "inserting before node" << endl;
	node = CreateNode(1000);
	mynode = SearchNode(&head,2);
	InsertNodeBefore(mynode,node);

	count = CountNode(&head);
	for ( i = 0; i < count; i++)
	{
		mynode = SearchNode(&head,i);
		cout << "[" << i << "]" << mynode->data << endl;
	}
	return 0;
}

#pragma region 단순연결리슨트
//20214 유건욱
//#include <iostream>
//
//using namespace std;
//
//typedef struct linked
//{
//	int data;
//	struct linked* next;
//}node;
//
//
//node* head = NULL;
//node* tail = NULL;
//
//void Init();
//void Insert(node* ptr);
//void PrintList(node* ptr);
//void Modify(node* ptr);
//void InsertData(node* ptr);
//void Delete(node* ptr);
//
//
//
//int main()
//{
//	int menu = 0;
//	Init();
//	while (true)
//	{
//		cout << "1.입력 2.출력 3.수정 4.삽입 5.삭제 6.종료" << endl;
//		cout << "input menu : ";
//		cin >> menu;
//
//		switch (menu)
//		{
//		case 1:
//			Insert(tail);
//			break;
//		case 2:
//			PrintList(head);
//			break;
//		case 3:
//			Modify(head);
//			break;
//		case 4:
//			InsertData(head);
//			break;
//		case 5:
//			Delete(head);
//			break;
//		case 6:
//			break;
//		default:
//			cout << "select menu error.." << endl;
//			break;
//		}
//		if (menu == 6)
//			break;
//
//	}
//	return 0;
//}
//void Init()
//{
//	head = new node;
//
//	head->data = 0;
//	head->next = NULL;
//
//	tail = head;
//
//	return;
//}
//
//void Insert(node* ptr)
//{
//	node* newnode = new node;
//	int num = 0;
//
//	cout << "input number : ";
//	cin >> num;
//
//	newnode->data = num;
//	newnode->next = NULL;
//
//	ptr->next = newnode;
//	tail = newnode;
//	return;
//
//}
//
//void PrintList(node* ptr)
//{
//	node* view = ptr->next;
//	while (view != NULL)
//	{
//		cout << view->data;
//		view = view->next;
//	}
//	cout << endl;
//	return;
//}
//
//void Modify(node* ptr)
//{
//	int index = 0;
//	int num = 0;
//	int i;
//
//	cout << "input modify index : ";
//	cin >> index;
//	cout << "input modify data : ";
//	cin >> num;
//
//	for (int i = 0; i < index; i++)
//	{
//		ptr = ptr->next;
//	}
//
//	ptr->data = num;
//	return;
//}
//
//void InsertData(node* ptr)
//{
//	node* newnode = new node;
//
//	int index = 0, num = 0;
//	int i;
//
//	cout << "index InsertData index";
//	cin >> index;
//
//	cout << "input data";
//	cin >> num;
//
//	for (int i = 0; i < index; i++)
//	{
//		ptr = ptr->next;
//	}
//
//	newnode->data = num;
//	newnode->next = NULL;
//
//	if (ptr->next == NULL)
//	{
//		ptr->next = newnode;
//		tail = newnode;
//	}
//	else
//	{
//		newnode->next = ptr->next;
//		ptr->next = newnode;
//
//	}
//	return;
//}
//
//void Delete(node* ptr)
//{
//	node* temp = 0;
//	int i;
//	int index;
//
//	if (head == tail)
//	{
//		cout << "not found" << endl;
//		return;
//	}
//
//	cout << "input del index : ";
//	cin >> index;
//
//	for (int i = 0; i < index - 1; i++)
//	{
//		ptr = ptr->next;
//
//	}
//	temp = ptr->next;
//
//	if (temp->next == NULL)
//	{
//		ptr->next = NULL;
//		tail = ptr;
//	}
//	else
//	{
//		ptr->next = temp->next;
//	}
//	delete(temp);
//	return;
//}
#pragma endregion
