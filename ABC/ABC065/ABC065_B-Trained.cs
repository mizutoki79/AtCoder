using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AtCoder
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = Enumerable.Repeat(0, n)
                                .Select(x => int.Parse(Console.ReadLine()) - 1)
                                .ToArray();
            bool[] isTouched = new bool[n];
            int idx = 0, cnt = 0;
            bool canTwo = false;
            while (true)
            {
                cnt++;
                isTouched[idx] = true;
                int newIdx = a[idx];
                Console.Error.WriteLine("{0} -> {1}", idx, newIdx);
                if (newIdx == 1)
                {
                    canTwo = true;
                    break;
                }
                else if (idx == newIdx || isTouched[newIdx])
                {
                    canTwo = false;
                    break;
                }
                idx = newIdx;
            }
            Console.WriteLine(canTwo ? cnt : -1);
        }
    }
}
