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
        long k = long.Parse(inputs[1]);
        long sum = Console.ReadLine().Split(' ')
                    .Select(elem => long.Parse(elem))
                    .OrderBy(elem => elem)
                    .Where((elem, idx) => idx < k)
                    .Sum();
        sum += k * (k - 1) / 2;
        Console.WriteLine(sum);
    }
}