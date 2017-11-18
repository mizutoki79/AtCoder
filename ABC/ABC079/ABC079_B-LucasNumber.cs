using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC079.B
{
    class Program
    {
        static void Main ()
        {
            const int MaxN = 86;
            var L = new long[MaxN + 1];
            L[0] = 2;
            L[1] = 1;
            int n = int.Parse (Console.ReadLine ());
            int i = 2;
            while (L[n] == 0)
            {
                L[i] = L[i - 1] + L[i - 2];
                i++;
            }
            Console.WriteLine (L[n]);
        }
    }
}