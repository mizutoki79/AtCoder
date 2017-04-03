using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
 
class Program{
    static void Main(){
         int n = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split(' ');
        int[] a = new int[n];
        for(int i = 0; i < n; i++){
            a[i] = int.Parse(inputs[i]);
        }
        bool[] check = new bool[n];
        int cnt = 0;
        for(int i = 0; i < n; i++){
            if(!check[i]){
                if(a[a[i] - 1] == i + 1){
                    cnt++;
                    check[a[i] - 1] = true;
                }
                check[i] = true;
            }
        }
        Console.WriteLine(cnt);
    }
}