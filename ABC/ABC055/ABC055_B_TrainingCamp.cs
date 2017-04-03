using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
 
class Program
{
    const int Modulus = 1000000007;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long power = 1;
        for (int i = 0; i < n; i++)
        {
            power = power * (i + 1) % Modulus;
        }
        Console.WriteLine(power);
    }
}