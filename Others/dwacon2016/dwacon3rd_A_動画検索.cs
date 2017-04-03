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
        Console.WriteLine(a + b > n ? a + b - n : 0);
    }
}
