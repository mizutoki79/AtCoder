#include <iostream>
#define REP(i, n) for(int i = 0; i < n; i++)

int main()
{
    const int INF = 999999999;
    const int MAX_N = 50;
    const int MAX_M = 50;
    int n, m;
    int a[MAX_N];
    int b[MAX_N];
    int c[MAX_M];
    int d[MAX_M];
    std::cin >> n >> m;
    REP(i, n) std::cin >> a[i] >> b[i];
    REP(i, m) std::cin >> c[i] >> d[i];
    REP(i, n)
    {
        int min = INF, point;
        REP(j, m)
        {
            int distance = std::abs(a[i] - c[j]) + std::abs(b[i] - d[j]);
            if(min > distance)
            {
                min = distance;
                point = j + 1;
            }
        }
        std::cout << point << std::endl;
    }
}