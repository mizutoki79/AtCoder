using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC090.C
{
    class Program
    {
        static void Main ()
        {
            decimal[] inputs = Console.ReadLine ().Split (' ')
                .Select (elem => decimal.Parse (elem))
                .ToArray ();
            decimal N = inputs[0];
            decimal M = inputs[1];
            decimal result = 0;
            if (N < 2 && M < 2) { result = 1; }
            else if (M == 1) result = N - 2;
            else if (N == 1) result = M - 2;
            else
            {
                result = (N - 2) * (M - 2);
            }
            Console.WriteLine (result);
        }
    }
}