#pragma once
typedef int BTData;
struct BTreeNode
{
    BTData data;
    struct BTreeNode* left;
    struct BTreeNode* right;
};
BTreeNode* MakeBTreeNode(void);
BTData GetData(BTreeNode* bt);
void SetData(BTreeNode* bt, BTData data);

BTreeNode* GetLeftSubTree(BTreeNode* bt);
BTreeNode* GetRightSubTree(BTreeNode* bt);

void MakeLeftSubTree(BTreeNode* main, BTreeNode* sub);
void MakeRightSubTree(BTreeNode* main, BTreeNode* sub);

void PostorderTraverse(BTreeNode* bt);
void PreorderTraverse(BTreeNode* bt);
void InorderTraverse(BTreeNode* bt);