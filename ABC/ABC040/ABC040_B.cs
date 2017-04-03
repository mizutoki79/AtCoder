//mcs main.mcs - compile
//mono main.exe - run
using System;
//using System.Linq;
//using System.Collections;
//using System.Collections.Generic;
//using System.Diagnostics;

class Program{
    static void Main(){
        int n;
        n = int.Parse(Console.ReadLine());
        int h = (int)Math.Sqrt(n);
        //Console.Error.WriteLine("initial {0}", h);
        int w = h;
        int S = 0;
        int min = int.MaxValue;
        while((int)Math.Abs(w - h) < min){
            S = h * w;
            if(S > n){
                w--;
                h--;
            }
            else min = (n - S + w - h) < min ? (n - S + w - h) : min;
            //Console.Error.WriteLine("h {0} w {1} S {2} min {3}", h, w, S, min);
            w++;
        }
        Console.WriteLine(min);
    }
}