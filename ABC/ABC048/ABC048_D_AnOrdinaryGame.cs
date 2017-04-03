using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
 
class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        var equal = input[0] == input[input.Length - 1];
        var even = input.Length % 2 == 0;
        Console.WriteLine(equal ^ even ? "Second" : "First");
    }
}
