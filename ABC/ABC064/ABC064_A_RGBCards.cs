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
        int num = int.Parse(Console.ReadLine().Replace(" ", ""));
        Console.WriteLine(num % 4 == 0 ? "YES" : "NO");
    }
}
