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
        const int Max = 50;
        string O = Console.ReadLine();
        string E = Console.ReadLine();
        for (int i = 0; i < Max; i++)
        {
            if(i < O.Length) Console.Write(O[i]);
            else break;
            if(i < E.Length) Console.Write(E[i]);
            else break;
        }
        Console.WriteLine();
    }
}