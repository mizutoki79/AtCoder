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
        int n = int.Parse(inputs[0]);
        int a = int.Parse(inputs[1]);
        int b = int.Parse(inputs[2]);

        long pattern = Math.Max(((long)(b - a) * (n - 2) + 1), 0);
        Console.WriteLine(pattern);
    }
}
