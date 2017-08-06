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
            string s = Console.ReadLine();
            Console.WriteLine("{0}{1}{2}", s[0], s.Length - 2, s[s.Length - 1]);
        }
    }
}