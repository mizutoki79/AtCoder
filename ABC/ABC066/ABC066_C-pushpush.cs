using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AtCoder.ABC066
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var a = Console.ReadLine().Split(' ').Select(elem => int.Parse(elem));
            var aEven = a.Where((elem, idx) => idx % 2 != 0).ToArray();
            var aOdd = a.Where((elem, idx) => idx % 2 == 0).ToArray();
            var b = new int[n];
            if (n % 2 == 0)
            {
                Array.Reverse(aEven);
                Array.Copy(aEven, b, aEven.Length);
                Array.Copy(aOdd, 0, b, aEven.Length, aOdd.Length);
            }
            else
            {
                Array.Reverse(aOdd);
                Array.Copy(aOdd, b, aOdd.Length);
                Array.Copy(aEven, 0, b, aOdd.Length, aEven.Length);
            }
            Console.WriteLine(String.Join(" ", b));
        }
    }
}