using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC079.C
{
    class Program
    {
        static void Main ()
        {
            var inputs = Console.ReadLine ().Select (elem => int.Parse (elem.ToString ()))
                .ToArray ();
            const int aim = 7;
            int result = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        if (i == 0) result = inputs[0] + inputs[1];
                        else result = inputs[0] - inputs[1];
                        if (j == 0) result += inputs[2];
                        else result -= inputs[2];
                        if (k == 0) result += inputs[3];
                        else result -= inputs[3];
                        if (result == aim)
                        {
                            var ops = new char[] { '+', '-' };
                            Console.WriteLine (inputs[0].ToString () + ops[i] + inputs[1] + ops[j] + inputs[2] + ops[k] + inputs[3] + "=7");
                            return;
                        }
                    }
                }
            }
        }
    }
}