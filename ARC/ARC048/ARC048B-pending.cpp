#include <iostream>
#include <string>
using namespace std;

int janken(int i, int j){
    int result = 0;
    if(i == j) result = 2;
    else if((i == 1 && j == 2) || (i == 2 && j == 3) || (i == 3 && j == 1)){
        result = 0;
    }
    else{
        result = 1;
    }
    return result;
}

int main(){
    long N, R[100000];
    int H[100000], v[100000][3];
    cin >> N;
    for(int i = 0; i < N; i++){
        cin >> R[i] >> H[i];
    }
    for(int i = 0; i < N; i++){
        for(int j = i + 1; j < N; j++){
            if(R[i] > R[j]){
                v[i][0]++;
                v[j][1]++;
            }
            else if(R[i] < R[j]){
                v[i][1]++;
                v[j][0]++;
            }
            else if(R[i] == R[j]){
                int tmp = janken(H[i], H[j]);
                if(tmp == 0){
                    v[i][0]++;
                    v[j][1]++;
                }
                else if(tmp == 1){
                    v[i][1]++;
                    v[j][0]++;
                }
                else if(tmp == 2){
                    v[i][2]++;
                    v[j][2]++;
                }
            }
        }
    }
    for(int i = 0; i < N; i++){
        for(int j = 0; j < 3; j++){
            if(j != 0) cout << ' ';
            cout << v[i][j];
        }
        cout << endl;
    }
    return 0;
}