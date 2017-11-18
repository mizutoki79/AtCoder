using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC079.D
{
    class Program
    {
        static void Main ()
        {
            var hw = Console.ReadLine ().Split (' ');
            int H = int.Parse (hw[0]);
            int W = int.Parse (hw[1]);
            var c = new int[10][];
            var A = new int[H][];
            for (int i = 0; i < 10; i++)
            {
                var inputs = Console.ReadLine ().Split (' ')
                    .Select (elem => int.Parse (elem))
                    .ToArray ();
                c[i] = inputs;
            }
            for (int i = 0; i < H; i++)
            {
                var inputs = Console.ReadLine ().Split (' ')
                    .Select (elem => int.Parse (elem))
                    .ToArray ();
                A[i] = inputs;
            }

            var costToOne = new int[10];
            var isFinal = new bool[10];
            for (int i = 0; i < 10; i++)
            {
                costToOne[i] = c[i][1];
            }
            isFinal[1] = true;
            while (isFinal.Contains (false))
            {
                int minval = int.MaxValue;
                int minidx = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (isFinal[i]) continue;
                    if (minval > costToOne[i])
                    {
                        minval = costToOne[i];
                        minidx = i;
                    }
                }
                int j = minidx;
                isFinal[j] = true;
                for (int i = 0; i < 10; i++)
                {
                    if (isFinal[i]) continue;
                    if (costToOne[i] > costToOne[j] + c[i][j])
                    {
                        costToOne[i] = costToOne[j] + c[i][j];
                    }
                }
            }

            int mp = 0;
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (A[i][j] == -1) continue;
                    mp += costToOne[A[i][j]];
                }
            }
            Console.WriteLine (mp);
        }
    }
}