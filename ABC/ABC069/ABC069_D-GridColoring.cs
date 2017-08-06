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
            int[] inputs = Console.ReadLine().Split(' ')
                        .Select(int.Parse)
                        .ToArray();
            int H = inputs[0];
            int W = inputs[1];
            int n = int.Parse(Console.ReadLine());
            int[] a = Console.ReadLine().Split(' ')
                        .Select(int.Parse)
                        .ToArray();
            var onelinec = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var tmpc = Enumerable.Repeat(i + 1, a[i]);
                onelinec.AddRange(tmpc);
            }
            Console.Error.WriteLine(string.Join(" ", onelinec));
            var c = new int[H, W];
            for (int i = 0; i < H * W; i++)
            {
                if ((i / H) % 2 == 0)
                {
                    c[i % H, i / H] = onelinec[i];
                }
                else
                {
                    c[H - 1 - (i % H), i / H] = onelinec[i];
                }
            }
            for (int i = 0; i < H; i++)
            {
                for (int j = 0; j < W; j++)
                {
                    if (j != 0) Console.Write(" ");
                    Console.Write(c[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}