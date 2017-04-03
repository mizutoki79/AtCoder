#include <iostream>
#include <string>
#include <algorithm>
#include <set>
#define REP(i, n) for(int i = 0; i < n;i++)
using namespace std;
int main()
{
    int h, w;
    const int MAX = 100;
    char C[MAX][MAX];
    cin >> h >> w;
    REP(i, h) REP(j, w) cin >> C[i][j];
    REP(i, 2 * h) {REP(j, w) {cout << C[i / 2][j];} cout << endl;}
}