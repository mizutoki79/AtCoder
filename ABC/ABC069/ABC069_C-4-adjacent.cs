using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC069
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long[] inputs = Console.ReadLine().Split(' ')
                        .Select(long.Parse)
                        .ToArray();
            int odd = 0, four = 0, even = 0;
            foreach (var item in inputs)
            {
                if (item % 4 == 0) four++;
                else if (item % 2 == 0) even++;
                else odd++;
            }
            string result = "No";
            if (odd - four <= 0 || (even == 0 && odd - four <= 1)) result = "Yes";
            Console.WriteLine(result);
        }
    }
}