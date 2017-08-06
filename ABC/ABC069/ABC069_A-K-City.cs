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
            string[] inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]) - 1;
            int m = int.Parse(inputs[1]) - 1;
            Console.WriteLine(n * m);
        }
    }
}