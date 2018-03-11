using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC090.B
{
    class Program
    {
        static void Main ()
        {
            string[] inputs = Console.ReadLine ().Split (' ');
            int res = int.Parse (inputs[1].Substring (0, 3)) - int.Parse (inputs[0].Substring (0, 3));
            if (int.Parse (string.Join ("", inputs[0].Substring (0, 2).Reverse ().ToArray ())) >= int.Parse (inputs[0].Substring (3, 2)))
            {
                res++;
            }
            if (int.Parse (string.Join ("", inputs[1].Substring (0, 2).Reverse ().ToArray ())) > int.Parse (inputs[1].Substring (3, 2)))
            {
                res--;
            }
            Console.WriteLine (res);
        }
    }
}