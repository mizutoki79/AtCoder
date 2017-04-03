//$g++ main.cpp - compile
//$./a.out - run
#include <iostream>
#include <string>
#include <cctype>
#include <stdio.h>
#include <string.h>
using namespace std;
 
int main(){
    int W, H;
	cin >> W >> H;
	if(W == H * 4 / 3){
		cout << "4:3";
	}
    else{
        cout << "16:9";
    }
    cout << endl;
}