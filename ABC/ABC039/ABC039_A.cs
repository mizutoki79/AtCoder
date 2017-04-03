//mcs main.mcs - compile
//mono main.exe - run
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class Program{
    static void Main(){
        int a, b, c, s = 0;
        string[] inp = Console.ReadLine().Split(' ');
        a = int.Parse(inp[0]);
        b = int.Parse(inp[1]);
        c = int.Parse(inp[2]);
        s += 2 * (a * b + b * c + c * a);
        Console.WriteLine(s);
    }
}