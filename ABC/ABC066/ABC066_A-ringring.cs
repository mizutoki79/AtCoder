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
            Console.WriteLine(Console.ReadLine().Split(' ').Select(elem => int.Parse(elem)).OrderBy(elem => elem).Where((elem, idx) => idx < 2).Sum());
        }
    }
}