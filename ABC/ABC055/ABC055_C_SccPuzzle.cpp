#include <bits/stdc++.h>
using namespace std;

int main()
{
    long long n, m, cnt;
    cin >> n >> m;
    if(n <= m / 2) cnt = n + (m - n * 2) / 4;
    else cnt = m / 2;
    cout << cnt << endl; 
}