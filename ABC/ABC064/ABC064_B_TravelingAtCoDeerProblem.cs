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
        int n = int.Parse(Console.ReadLine());
        int[] a = Console.ReadLine().Split(' ')
                    .Select(elem => int.Parse(elem))
                    .OrderBy(elem => elem)
                    .ToArray();
        Console.WriteLine(a[n - 1] - a[0]);
    }
}
