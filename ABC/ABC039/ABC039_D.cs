//mcs main.mcs - compile
//mono main.exe - run
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class Program{
    static void Main(){
        int h, w;
        string[] inp = Console.ReadLine().Split(' ');
        h = int.Parse(inp[0]);
        w = int.Parse(inp[1]);
        char[,] s = new char[h, w];
        char[,] ans = new char[h, w];
        for(int i = 0; i < ans.GetLength(0); i++){
            for(int j = 0; j < ans.GetLength(1); j++){
                ans[i, j] = '.';
            }
        }
        for(int i = 0; i < h; i++){
            char[] inp1 = Console.ReadLine().ToCharArray();
            for(int j = 0; j < w; j++){
                s[i, j] = inp1[j];
            }
        }
        
        for(int i = 0; i < s.GetLength(0); i++){
            for(int j = 0; j < s.GetLength(1); j++){
                if(search(s, i, j)){
                    Toggle(ans, i, j);
                }
            }
        }
        char[,] compAns = compress(ans);
        if(compare(s, compAns, h, w)){
            Console.WriteLine("possible");
            showPic(ans);
        }
        else{
            Console.WriteLine("impossible");
        }
    }

    static void Toggle(char[,] pic, int y, int x){
        if(pic[y, x] == '.') pic[y, x] = '#';
        else pic[y, x] = '.';
    }

    static void FillAround(char[,] pic, int y, int x, char color){
        for(int i = y - 1; i <= y + 1; i++){
            for(int j = x - 1; j <= x + 1; j++){
                if(i >= 0 && j >= 0 && i < pic.GetLength(0) && j < pic.GetLength(1)){
                    if(!(i == y && j == x)){
                        pic[i, j] = color;
                    }
                }
            }
        }
    }

    static bool search(char[,] pic, int y, int x){
        if(pic[y, x] == '.') return false;
        for(int i = y - 1; i <= y + 1; i++){
            for(int j = x - 1; j <= x + 1; j++){
                if(i >= 0 && j >= 0 && i < pic.GetLength(0) && j < pic.GetLength(1)){
                    if(pic[i, j] == '.') return false;
                }
            }
        }
        return true;
    }

    static char[,] compress(char[,] pic){
        char[,] tmp = (char[,])pic.Clone();
        for(int i = 0; i < pic.GetLength(0); i++){
            for(int j = 0; j < pic.GetLength(1); j++){
                if(pic[i, j] == '#'){
                    FillAround(tmp, i, j, '#');
                }
            }
        }
        return tmp;
    }

    static bool compare(char[,] pic1, char[,] pic2, int h, int w){
        for(int i = 0; i < h; i++){
            for(int j = 0; j < w; j++){
                if(pic1[i, j] != pic2[i, j]) return false;
            }
        }
        return true;
    }

    static void showPic(char[,] pic){
        for(int i = 0; i < pic.GetLength(0); i++){
            for(int j = 0; j < pic.GetLength(1); j ++){
                Console.Write(pic[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void showPic(char[,] pic, string message){
        Console.WriteLine(message);
        showPic(pic);
    }
}