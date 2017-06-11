using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
 
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[] s = Console.ReadLine().ToCharArray();
        int opening = 0, closing = 0;
        for (int i = 0; i < n; i++)
        {
            if (s[i] == '(') opening++;
            else if (s[i] == ')')
            {
                if (opening >= 1) opening--;
                else closing++;
            }
        }
        for (int i = 0; i < closing; i++) Console.Write('(');
        Console.Write(s);
        for (int i = 0; i < opening; i++) Console.Write(')');
        Console.WriteLine();
        // var result = new string(Enumerable.Concat(Enumerable.Concat(Enumerable.Repeat('(', closing), s), Enumerable.Repeat(')', opening)).ToArray());
        // Console.WriteLine(result);
    }
}
