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
        char[] a = "CODEFESTIVAL2016".ToCharArray();
        int cnt = 0;
        for(int i = 0; i < 16; i++){
            if(s[i] != a[i]) cnt++;
        }
        Console.WriteLine(cnt);
    }
}