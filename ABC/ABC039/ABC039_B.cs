//mcs main.mcs - compile
//mono main.exe - run
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class Program{
    static void Main(){
        int x, n;
        x = int.Parse(Console.ReadLine());
        n = (int)Math.Pow(x, 1.0 / 4.0);
        Console.WriteLine(n);
    }
}