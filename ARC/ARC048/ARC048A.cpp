#include <iostream>
#include <string>
using namespace std;

int main(){
    long A, B;
    cin >> A >> B;
    if((A > 0 && B > 0) || (A < 0 && B < 0)){
        cout << B - A << endl;
    }
    else{
        cout << B - A - 1 << endl;
    }
}