using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
 
class Program{
    static void Main(){
        string s = Console.ReadLine();
        string ans = "No";
        if(((s.Contains('N') && s.Contains('S')) || (!s.Contains('N') && !s.Contains('S'))) 
        && ((s.Contains('W') && s.Contains('E')) || (!s.Contains('W') && !s.Contains('E')))){
            ans = "Yes";
        }
        Console.WriteLine(ans);
    }
}