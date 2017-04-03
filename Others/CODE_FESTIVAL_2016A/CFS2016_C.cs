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
        long k = long.Parse(Console.ReadLine());
        long remain = k;
        for(int i = 0; i < s.Length; i++){
            if(s[i] == 'a') continue;
            int gap = 'z' - s[i] + 1;
            if(gap <= remain){
                s[i] = 'a';
                remain -= gap;
            }
            if(remain == 0) break;
        }
        s[s.Length - 1] = (char)(s[s.Length - 1] + remain % 26);
        for(int i = 0; i < s.Length; i++){
            Console.Write(s[i]);
        }
        Console.WriteLine();
    }
}