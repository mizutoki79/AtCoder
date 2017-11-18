using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC0
{
    class Program
    {
        static void Main ()
        {
            var n = Console.ReadLine ();
            if (n[0].Equals (n[1]) && n[1].Equals (n[2]) || n[1].Equals (n[2]) && n[2].Equals (n[3]))
            {
                Console.WriteLine ("Yes");
            }
            else Console.WriteLine ("No");
        }
    }
}