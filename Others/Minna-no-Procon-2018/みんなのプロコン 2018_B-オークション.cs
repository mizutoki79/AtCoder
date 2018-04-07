using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.minpro2018.B
{
    class Program
    {
        static void Main ()
        {
            int[] inputs = Console.ReadLine ().Split (' ')
                .Select (elem => int.Parse (elem))
                .ToArray ();
            int X = inputs[0];
            int K = inputs[1];
            int K2 = (int) Math.Pow (10, K);
            Console.WriteLine (Math.Floor ((double) (X + K2) / K2) * K2);
        }
    }
}