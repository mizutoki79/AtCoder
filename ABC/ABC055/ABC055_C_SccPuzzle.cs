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
        string[] inputs = Console.ReadLine().Split(' ');
        long n = long.Parse(inputs[0]);
        long m = long.Parse(inputs[1]);
        long cnt = 0;
        if(n <= m / 2) cnt = n + (m - n * 2) / 4;
        else cnt = m / 2;
        Console.WriteLine(cnt);
    }
}