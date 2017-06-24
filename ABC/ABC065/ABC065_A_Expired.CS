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
            string[] inputs = Console.ReadLine().Split(' ');
            int x = int.Parse(inputs[0]);
            int a = int.Parse(inputs[1]);
            int b = int.Parse(inputs[2]);
            string result = "dangerous";
            if (a >= b)
            {
                result = "delicious";
            }
            else if (x >= (b - a))
            {
                result = "safe";
            }
            Console.WriteLine(result);
        }
    }
}
