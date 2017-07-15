using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AtCoder.ABC066
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int i = input.Length;
            while (--i > 0)
            {
                if (!isEvenString(input, i)) continue;
                Console.WriteLine(i);
                return;
            }
        }

        static bool isEvenString(string str, int leng)
        {
            if (leng % 2 != 0) return false;
            string str1 = str.Substring(0, leng / 2);
            string str2 = str.Substring(leng / 2, leng / 2);
            return str1 == str2;
        }
    }
}