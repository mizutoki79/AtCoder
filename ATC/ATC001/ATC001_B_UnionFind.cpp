//$g++ main.cpp - compile
//$./a.out - run
#include <iostream>
/*#include <string>
#include <cctype>
#include <cmath>
#include <stdio.h>
#include <string.h>
#include <iostream>
#include <regex>
#include <list>*/
using namespace std;

const int MAX_N = 100000;
const int MAX_Q = 200000;
int parent[MAX_N] = {};
int treeRank[MAX_N] = {};
int P = 0, A = 0, B = 0;
string answer[MAX_Q] = {};
int numOfjudge = 0;

void init(int n){
    for(int i = 0; i < n; i++){
        parent[i] = i;
        treeRank[i] = 0;
    }
}

int root(int x){
    return parent[x] == x ? x : parent[x] = root(parent[x]);
}

bool isSame(int x, int y){
    return root(x) == root(y);
}

void unit(int x, int y){
    x = root(x);
    y = root(y);
    if(x == y) return;
    
    if(treeRank[x] < treeRank[y]){
        parent[x] = y;
    }
    else{
        parent[y] = x;
        if(treeRank[x] == treeRank[y]) treeRank[x]++;
    }
}

int main(){
    int N, Q;
    cin >> N >> Q;
    init(N);
    for(int i = 0; i < Q; i++){
        cin >> P >> A >> B;
        if(P == 0) unit(A, B);
        else{
            answer[numOfjudge++] = isSame(A, B) ? "Yes" : "No";
        }
    }
    for(int i = 0; i < numOfjudge; i++){
        cout << answer[i] << endl;
    }
}