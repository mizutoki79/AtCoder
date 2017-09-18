#define llong long long
#define REP(i, n) for (int i = 0; i < n; i++)
#include <iostream>
#include <algorithm>
using namespace std;
static const llong INF = 9999999999;

int main()
{
    int n, a;
    cin >> n >> a;
    cout << n * n - a;
}