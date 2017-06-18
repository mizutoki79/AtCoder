using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AtCoder
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            int slen = s.Length;
            char[] Alp = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int result = int.MaxValue;
            foreach (var item in Alp)
            {
                string[] splitS = s.Split(item);
                int maxLength = splitS.Select(elem => elem.Length).Max();
                result = Math.Min(result, maxLength);
            }
            Console.WriteLine(result);
        }
    }
}
