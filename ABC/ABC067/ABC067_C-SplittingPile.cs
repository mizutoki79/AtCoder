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
            int n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split(' ')
                        .Select(long.Parse)
                        .ToArray();
            long sum1 = a[0], sum2 = a.Sum() - a[0], diff = 0, minDiff = Math.Abs(sum2 - sum1);
            for (int i = 1; i < n - 1; i++)
            {
                sum1 += a[i];
                sum2 -= a[i];
                diff = Math.Abs(sum2 - sum1);
                if (minDiff > diff) minDiff = diff;
                else break;
            }
            Console.WriteLine(minDiff);
        }
    }
}