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
        const long divisor = 1000000000 + 7;
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            long result = 0;
            decimal gap = Math.Abs(n - m);
            if (gap <= 1)
            {
                long npermutation = ModFactorial(n);
                long mpermutation = ModFactorial(m);
                result = npermutation * mpermutation % divisor;
                Console.Error.WriteLine("result1 = {0}", result);
                if (gap == 0)
                {
                    result = result * 2 % divisor;
                    Console.Error.WriteLine("result2 = {0}", result);
                }
            }
            Console.WriteLine(result);
        }

        static long ModFactorial(int n)
        {
            long result = 1;
            while (n > 1)
            {
                result = result * n % divisor;
                n--;
            }
            return result;
        }
    }
}
