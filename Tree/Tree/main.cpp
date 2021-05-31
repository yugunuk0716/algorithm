//20214 유건욱

#include <iostream>
#include "Binary.h"
using namespace std;

int main() 
{
    BTreeNode* bt1 = MakeBTreeNode();
    BTreeNode* bt2 = MakeBTreeNode();
    BTreeNode* bt3 = MakeBTreeNode();
    BTreeNode* bt4 = MakeBTreeNode();
    BTreeNode* bt5 = MakeBTreeNode();
    BTreeNode* bt6 = MakeBTreeNode();

    SetData(bt1, 1);
    SetData(bt2, 2);
    SetData(bt3, 3);
    SetData(bt4, 4);
    SetData(bt5, 5);
    SetData(bt6, 6);

    MakeLeftSubTree(bt1, bt2);
    MakeRightSubTree(bt1, bt3);
    MakeLeftSubTree(bt2, bt4);
    MakeRightSubTree(bt2, bt5);
    MakeRightSubTree(bt2, bt6);
    
    PreorderTraverse(bt1);
    cout << endl;
    InorderTraverse(bt1);
    cout << endl;
    PostorderTraverse(bt1);
    cout << endl;


    return 0;
}

/*

#pragma region 자료형 정의
//자료형 정의
typedef BTData int;
struct BTreeNode
{
    BTData data;//트리에 실제 정보를 담고자 하는 자료형 선언
    struct BTreeNode* left;//왼쪽 자식 노드를 가리키기 위한 포인터 변수 선언
    struct BTreeNode* right;//오른쪽 자식 노드를 가리키기 위한 포인터 변수 선언
};
#pragma endregion
#pragma region 노드 생성
BTreeNode* bt1 = MakeBTreeNode(); // MakeBTreeNode()함수를 만들어 BTreeNode 형의 메모리를 만들수 있도록 하고, 이 메모리 주솟값을 반환 받을 수 있게 한다

BTreeNode* MakeBTreeeNode(void)
{
    BTreeNode* nd = new BTreeNode;// 동적 메모리를 할당하는 부분이다

    nd->left = NULL; // BTreeNode 형으로 생성된 nd의 left와 right 포인터에는 현재 대입 되는 다른 노드의 주소가 없기 때문에 NULL 값을 넣는다. 이후 자식 노드의 주솟값을 여기에 넣는다
    nd->right = NULL;
    return nd;//nd에 대한 정의가 모두 끝났으면 nd 주솟값을 반환해준다
}
#pragma endregion
#pragma region 메모리 삭제 함수
Delete(bt);

void Delete(BTreeNode* bt)
{
    delete bt;//bt가 가리키고 있는 메모리를 삭제한다
}
#pragma endregion

#pragma region 노드에 값 설정
SetData(bt1,1);// 첫번째 인자에는 정보를 넣을 노드의 주솟ㄱ값을 넣고 두번 째 인자에는 입력시킬 자룟값을 넣는다

void SetData(BTreeNode*bt, BTData data)
{
    bt->data = data
}
#pragma endregion

#pragma region 이진트리 관계 설정
MakeLeftSubTree(bt1, bt2);// 첫 인자 값은 부모 노드에 해당하는 노드의 주솟값을 넣어주고 두번 째 인자는 왼쪽 자식 노드로 연결할 노드의 주솟값을 넣어 준다
MakeRightSubTree(bt1, bt3);// 첫 인자 값은 부모 노드에 해당하는 노드의 주솟값을 넣어주고 두번 째 인자는 오른쪽 자식 노드로 연결할 노드의 주솟값을 넣어 준다


void MakeLeftSubTree(BTreeNode*main,BTreeNode*sub)
{
    if (main->left != NULL)
    {
        delete main->left;//이미 할당된 노드가 있다면, 기존 노드를 삭제
    }
    main->left = sub;
}
void MakeRightSubTree(BTreeNode* main, BTreeNode* sub)
{
    if (main->right != NULL)
    {
        delete main->right;//이미 할당된 노드가 있다면, 기존 노드를 삭제
    }
    main->right = sub;
}
#pragma endregion

typedef int BTData;
struct BTreeNode
{
    BTData data;
    struct BTreeNode* left;
    struct BTreeNode* right;
};

BTreeNode* MakeBTreeNode(void)
{
    BTreeNode* nd = new BTreeNode;

    nd->left = NULL;
    nd->right = NULL;
    return nd;
}
void DeleteBTreeNode(BTreeNode* bt)
{
    delete bt;
}
BTData GetData(BTreeNode* bt)
{
    return bt->data;

}
void SetData(BTreeNode* bt, BTData data)
{
    bt->data = data;
}
BTreeNode* GetLeftSubTree(BTreeNode* bt)
{
    return bt->left;
}
BTreeNode* GetRightSubTree(BTreeNode* bt)
{
    return bt->right;
}
void MakeLeftSubTree(BTreeNode* main, BTreeNode* sub)
{
    if (main->left != NULL)
    {
        delete main->left;//이미 할당된 노드가 있다면, 기존 노드를 삭제
    }
    main->left = sub;
}
void MakeRightSubTree(BTreeNode* main, BTreeNode* sub)
{
    if (main->right != NULL)
    {
        delete main->right;//이미 할당된 노드가 있다면, 기존 노드를 삭제
    }
    main->right = sub;
}


int main()
{
    BTreeNode* bt1 = MakeBTreeNode();
    BTreeNode* bt2 = MakeBTreeNode();
    BTreeNode* bt3 = MakeBTreeNode();
    BTreeNode* bt4 = MakeBTreeNode();

    SetData(bt1, 1);
    SetData(bt2, 2);
    SetData(bt3, 3);
    SetData(bt4, 4);

    MakeLeftSubTree(bt1, bt2);
    MakeLeftSubTree(bt1, bt3);
    MakeLeftSubTree(bt2, bt4);

    cout << GetData(GetLeftSubTree(bt1)) << endl;
    cout << GetData(GetLeftSubTree(GetLeftSubTree(bt1))) << endl;

    DeleteBTreeNode(bt1);
    DeleteBTreeNode(bt2);
    DeleteBTreeNode(bt3);
    DeleteBTreeNode(bt4);

    return 0;
}

*/