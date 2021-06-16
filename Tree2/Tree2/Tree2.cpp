//20214 유건욱
#include <iostream>
#include <vector>
#include <stack>
#include <unordered_map>
using namespace std;
void printPreorder(int start, int end,
    vector<int> const& postorder, int& pIndex,
    unordered_map<int, int>& map, stack<int>& stack)
{
    if (start > end) {
        return;
    }

    int value = postorder[pIndex--];

    int index = map[value];

    printPreorder(index + 1, end, postorder, pIndex, map, stack);

    printPreorder(start, index - 1, postorder, pIndex, map, stack);
    stack.push(value);
}
void findPreorder(vector<int> const& inorder, vector<int> const& postorder)
{
    unordered_map<int, int> map;

    for (int i = 0; i < inorder.size(); i++) {
        map[inorder[i]] = i;
    }

    int lastIndex = inorder.size() - 1;
    stack<int> stack;

    printPreorder(0, lastIndex, postorder, lastIndex, map, stack);

    while (!stack.empty())
    {
        cout << stack.top() << ' ';
        stack.pop();
    }
}
int main()
{
    vector<int> inorder;
    vector<int> postorder;
    int n;
    cin >> n;
    int t;

    for (int i = 0; i < n; i++)
    {
        cin >> t;
        inorder.push_back(t);
    }
    for (int i = 0; i < n; i++)
    {
        cin >> t;
        postorder.push_back(t);
    }
    findPreorder(inorder, postorder);

    return 0;
}



