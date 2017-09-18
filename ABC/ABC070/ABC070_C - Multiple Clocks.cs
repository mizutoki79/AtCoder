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
            int n = int.Parse(Console.ReadLine());
            var T = new long[n];
            for (int i = 0; i < n; i++)
            {
                T[i] = long.Parse(Console.ReadLine());
            }
            long m = T[0];
            for (int i = 1; i < n; i++)
            {
                m = LCM(m, T[i]);
            }
            Console.WriteLine(m);
        }

        static long LCM(long a, long b)
        {
            long a0 = a, b0 = b;
            if (a < b)
            {
                var tmp = a;
                a = b;
                b = tmp;
            }
            var r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            return a0 / b * b0;
        }
    }
}