#include <iostream>
using namespace std;
int main()
{
    int x, y;
    cin >> x >> y;
    int cnt = 0;
    while(x != y)
    {
        if(abs(x) < abs(y))
        {
            if(x >= 0)
            {
                int tmp = abs(y) - abs(x);
                x += tmp;
                cnt += tmp;
            }
            else
            {
                x = -x;
                cnt++;
            }
        }
        else if(abs(x) > abs(y))
        {
            if(x > 0)
            {
                x = -x;
                cnt++;
            }
            else
            {
                int tmp = abs(x) - abs(y);
                x += tmp;
                cnt += tmp;
            }
        }
        else
        {
            x = -x;
            cnt++;
        }
        cerr << x << ' ' << y << endl;
    }
    cout << cnt << endl;
}