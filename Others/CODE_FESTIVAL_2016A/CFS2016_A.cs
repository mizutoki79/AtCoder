using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
 
class Program{
    static void Main(){
        char[] inputs = Console.ReadLine().ToCharArray();
        int n = inputs.Length + 1;
        char[] ans = new char[n];
        for(int i = 0; i < 4; i++){
            ans[i] = inputs[i];
        }
        ans[4] = ' ';
        for(int i = 4; i < n - 1; i++){
            ans[i + 1] = inputs[i];
        }
        for(int i = 0; i < n; i++){
            Console.Write(ans[i]);
        }
        Console.WriteLine();
    }
}