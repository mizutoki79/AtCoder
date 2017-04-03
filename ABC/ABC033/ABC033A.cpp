//$g++ main.cpp - compile
//$./a.out - run
#include <iostream>
#include <string>
using namespace std;

int main(){
	string N;
    char tmp;
    cin >> N;
    for(int i = 0; i < 4; i++){
        if(i == 0) tmp = N[i];
        else{
            if(tmp != N[i]) {
                cout << "DIFFERENT" <<endl;
                return 0;
            }
            tmp = N[i];
        }
    }
    cout << "SAME" << endl;
    return 0;
}