#include <bits/stdc++.h>

int main()
{
    int w, a, b, diff = 0;
    std::cin >> w >> a >> b;
    if(a + w < b) diff = b - (a + w);
    else if(b + w < a) diff = a - (b + w);
    std::cout << diff << std::endl;
}