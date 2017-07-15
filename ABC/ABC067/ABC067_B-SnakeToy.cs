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
            string[] inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]);
            int k = int.Parse(inputs[1]);
            int lengthOfSnake = Console.ReadLine().Split(' ')
                        .Select(int.Parse)
                        .OrderByDescending(elem => elem)
                        .Where((val, idx) => idx < k)
                        .Sum();
            Console.WriteLine(lengthOfSnake);
        }
    }
}