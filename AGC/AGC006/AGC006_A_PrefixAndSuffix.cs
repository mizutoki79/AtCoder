using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
 
class Program{
    static void Main(){
        int n = int.Parse(Console.ReadLine());
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        int i = 0;
        for (i = n; i > 0; i--)
        {
            if(a.EndsWith(b.Substring(0, i))) break;
        }
        Console.WriteLine(a.Length + b.Length - i);
    }
}