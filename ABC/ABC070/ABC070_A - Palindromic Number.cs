using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC070
{
    class Program
    {
        static void Main()
        {
            var n = Console.ReadLine();
            var result = "No";
            if (n[0] == n[2]) result = "Yes";
            Console.WriteLine(result);
        }
    }
}