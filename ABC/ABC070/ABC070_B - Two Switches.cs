using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC070
{
    class Program
    {
        static void Main()
        {
            int[] inputs = Console.ReadLine().Split(' ')
                        .Select(int.Parse)
                        .ToArray();
            Console.WriteLine(Math.Max(0, (Math.Min(inputs[1], inputs[3]) - Math.Max(inputs[0], inputs[2]))));
        }
    }
}