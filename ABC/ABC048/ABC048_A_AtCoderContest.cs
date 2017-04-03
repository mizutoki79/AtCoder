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
        Console.WriteLine(string.Concat('A', new string(Console.ReadLine().Where(elem => char.IsUpper(elem)).Skip(2).ToArray())));
    }
}
