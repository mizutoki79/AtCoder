using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.minpro2018
{
    class Program
    {
        static void Main ()
        {
            string S = Console.ReadLine ();
            Console.WriteLine (S.Substring (0, 3) == "yah" && S[3] == S[4] ? "YES" : "NO");
        }
    }
}