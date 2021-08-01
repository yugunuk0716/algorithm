//20214 유건욱
#include <iostream>

using namespace std;


void arr(int lv, int now, int n)
{
	if (lv == 1) {
		cout << now << endl;
		return;
	}
	int s = (1 << n) - (1 << (n - lv + 1));
	int l = (1 << (n - lv));

	cout << l - now + 1 + s << endl;
	
	arr(lv - 1, now, n);
	
	arr(lv - 1, now + (1 << (n - lv)), n);
}

int main()
{
	int n;
	cin >> n;
	system("cls");
	arr(n, 1, n);
}



#pragma region 트리 1번
//#include <iostream>
//#include <vector>
//using namespace std;
//
//int inorder[100001];
//int postorder[100001];
//int pos[100001];
//int n;
//
//void solve(int in_start, int in_end, int post_start, int post_end) {
//    if (in_start > in_end || post_start > post_end) return;
//    int root = postorder[post_end];
//    printf("%d ", root);
//    int p = pos[root]; 
//    int left = p - in_start;
//    solve(in_start, p - 1, post_start, post_start + left - 1);
//    solve(p + 1, in_end, post_start + left, post_end - 1);
//}
//int main()
//{
//    cin >> n;
//    for (int i = 0; i < n; i++) {
//        cin >> inorder[i];
//    }
//    for (int i = 0; i < n; i++) {
//        cin >> postorder[i];
//    }
//    for (int i = 0; i < n; i++) {
//        pos[inorder[i]] = i;
//    }
//    solve(0, n - 1, 0, n - 1);
//    return 0;
//}
#pragma endregion
