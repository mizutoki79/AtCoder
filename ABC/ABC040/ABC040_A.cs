//mcs main.mcs - compile
//mono main.exe - run
using System;
//using System.Linq;
//using System.Collections;
//using System.Collections.Generic;
//using System.Diagnostics;

class Program{
    static void Main(){
        int n, x;
        string[] inputs = Console.ReadLine().Split(' ');
        n = int.Parse(inputs[0]);
        x = int.Parse(inputs[1]);
        if(n / 2 >= x){
            Console.WriteLine(x - 1);
        }
        else{
            Console.WriteLine(n - x);
        }
    }
}