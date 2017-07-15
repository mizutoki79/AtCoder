using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AtCoder.ABC067
{
    class Program
    {
        static void Main()
        {
            int[] inputs = Console.ReadLine().Split(' ')
                        .Select(int.Parse)
                        .ToArray();
            int A = inputs[0];
            int B = inputs[1];

            if (A % 3 == 0 || B % 3 == 0 || (A + B) % 3 == 0)
            {
                Console.WriteLine("Possible");
            }
            else Console.WriteLine("Impossible");
        }
    }
}