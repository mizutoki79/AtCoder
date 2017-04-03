using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
 
class Program{
    static void Main(){
        char[] s = Console.ReadLine().ToCharArray();
        int t = int.Parse(Console.ReadLine());
        int h = 0, w = 0, q = 0;
        foreach(char ch in s){
            if(ch == 'L') w--;
            else if(ch == 'R') w++; 
            else if(ch == 'U') h++;
            else if(ch == 'D') h--;
            else q++;
        }
        int ans = 0;
        if(t == 1){
            ans = Math.Abs(w) + Math.Abs(h) + q;
        }
        else{
            ans = Math.Abs(w) + Math.Abs(h) - q;
            if(ans < 0) ans = ans % 2 == 0 ? 0 : 1;
        }
        Console.WriteLine(ans);
    }
}