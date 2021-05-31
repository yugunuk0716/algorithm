#include <iostream>
using namespace std;
#include "Binary.h"

void PostorderTraverse(BTreeNode* bt)
{
    if (bt == NULL)
        return;

    PostorderTraverse(bt->left);
    PostorderTraverse(bt->right);

    cout << bt->data << endl;
}
void PreorderTraverse(BTreeNode* bt)
{
    if (bt == NULL)
        return;

    cout << bt->data << endl;
    PreorderTraverse(bt->left);
    PreorderTraverse(bt->right);
}
void InorderTraverse(BTreeNode* bt)
{
    if (bt == NULL)
        return;

    InorderTraverse(bt->left);
    cout << bt->data << endl;
    InorderTraverse(bt->right);

   
}
BTreeNode* MakeBTreeNode(void)
{
    BTreeNode* nd = new BTreeNode;

    nd->left = NULL;
    nd->right = NULL;
    return nd;
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
        delete main->left;//�̹� �Ҵ�� ��尡 �ִٸ�, ���� ��带 ����
    }
    main->left = sub;
}
void MakeRightSubTree(BTreeNode* main, BTreeNode* sub)
{
    if (main->right != NULL)
    {
        delete main->right;//�̹� �Ҵ�� ��尡 �ִٸ�, ���� ��带 ����
    }
    main->right = sub;
}
