using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
 
class Program{
    static void Main(){
        int N = int.Parse(Console.ReadLine());
        long[] a = new long[N];
        for(int i = 0; i < N; i++){
            a[i] = long.Parse(Console.ReadLine());
        }

        long cnt = 0;
        for(int i = 0; i < N; i++){
            Console.Error.Write("a[{0}] = {1} ", i, a[i]);
            if(a[i] >= 2){
                cnt += a[i] / 2;
                a[i] = a[i] % 2;
            }
            if(a[i] != 0 && a[i] % 2 == 1){
                if(i > 0 && a[i - 1] > 0 && a[i] > 0){
                    long tmp = Math.Min(a[i - 1], a[i]);
                    cnt += tmp;
                    a[i - 1] -= tmp;
                    a[i] -= tmp;
                }
                if(i < a.Length - 1 && a[i + 1] > 0 && a[i] > 0){
                    long tmp = Math.Min(a[i + 1], a[i]);
                    cnt += tmp;
                    a[i] -= tmp;
                    a[i + 1] -= tmp;
                }
            }
            Console.Error.WriteLine("-> {0}, cnt {1}", a[i], cnt);
        }
        Console.WriteLine(cnt);
    }
}