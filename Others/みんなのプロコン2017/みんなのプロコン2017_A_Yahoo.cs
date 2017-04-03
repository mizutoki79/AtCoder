using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
 
class Program
{
    static void Main()
    {
        const int Leng = 5;
        char[] input = Console.ReadLine().ToCharArray();
        Array.Sort(input);
        char[] patten = "yahoo".ToCharArray();
        Array.Sort(patten);
        bool flag = true;
        for (int i = 0; i < Leng; i++)
        {
            if(input[i] == patten[i]) continue;
            flag = false;
            break;
        }
        Console.WriteLine(flag ? "YES" : "NO");
    }
}