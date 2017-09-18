using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC074
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var x = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                if (x[i] <= Math.Abs(k - x[i]))
                {
                    total += x[i] * 2;
                }
                else
                {
                    total += Math.Abs(k - x[i]) * 2;
                }
            }
            Console.WriteLine(total);
        }
    }
}