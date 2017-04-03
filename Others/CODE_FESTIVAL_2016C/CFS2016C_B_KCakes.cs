using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
 
class Program{
    static void Main(){
        string[] inputs = Console.ReadLine().Split(' ');
        int k = int.Parse(inputs[0]);
        int t = int.Parse(inputs[1]);
        int[] a = Console.ReadLine().Split(' ')
                                         .Select(val => int.Parse(val))
                                         .ToArray();
        int m = a.Max();
        Console.WriteLine(Math.Max(m - 1 - (k - m), 0));
    }
}
