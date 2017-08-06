using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AtCoder.ABC068
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<int> { 2, 4, 8, 16, 32, 64 };
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (n >= list[i])
                {
                    Console.WriteLine(list[i]);
                    return;
                }
            }
            Console.WriteLine(1);
        }
    }
}