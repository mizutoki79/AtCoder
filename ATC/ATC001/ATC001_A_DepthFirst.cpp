//$g++ main.cpp - compile
//$./a.out - run
#include <iostream>
#include <string>
#include <cctype>
#include <cmath>
#include <stdio.h>
#include <string.h>
#include <iostream>
#include <regex>
#include <list>
using namespace std;

const int MAX_H = 500;
const int MAX_W = 500;
int H = 0, W = 0;
char c[MAX_H][MAX_W] = {};
bool reached[MAX_H][MAX_W] = {};
int sx = 0, sy = 0, gx = 0, gy = 0;

void DepthFirst(int x, int y){
    if(x < 0 || W <= x || y < 0 || H <= y || c[x][y] == '#') return;
    if(reached[x][y]) return;
    
    reached[x][y] = true;
    
    DepthFirst(x + 1, y);
    DepthFirst(x - 1, y);
    DepthFirst(x, y + 1);
    DepthFirst(x, y - 1);
}

int main(){
    cin >> H >> W;
    for(int i = 0; i < W; i++){
        for(int j = 0; j < H; j++){
            cin >> c[i][j];
            if(c[i][j] == 's'){
                sx = i;
                sy = j;
            }
            else if(c[i][j] == 'g'){
                gx = i;
                gy = j;
            }
        }
    }
    
    DepthFirst(sx, sy);
    if(reached[gx][gy]) cout << "Yes" << endl;
    else cout << "No" << endl;
    return 0;
}