using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
 
class Program
{
    static void Main(){
        string pattern = @"^(dream|dreamer|erase|eraser)+$";
        Console.WriteLine(Regex.IsMatch(Console.ReadLine(), pattern) ? "YES" : "NO");
    }
}
