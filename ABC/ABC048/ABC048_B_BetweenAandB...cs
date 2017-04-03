using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
 
class Program
{
    static void Main()
    {
        long[] inputs = Console.ReadLine().Split(' ')
                                    .Select(val => long.Parse(val))
                                    .ToArray();
        Console.WriteLine(Func(inputs[1], inputs[2]) - Func(inputs[0] - 1, inputs[2]));
    }
    static long Func(long n, long x)
    {
        return n < 0 ? 0 : n / x + 1;
    }
}
