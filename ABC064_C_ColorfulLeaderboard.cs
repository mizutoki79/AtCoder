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
        int[] a = Console.ReadLine().Split(' ')
                    .Select(elem => int.Parse(elem))
                    .ToArray();
        bool existGrey = false, existBrown = false, existGreen = false, existLightBlue = false, existBlue = false, existYellow = false, existOrange = false, existRed = false;
        int NumberOfFreeColorPerson = 0;
        int cnt = 0;
        for (int i = 0; i < n; i++)
        {
            if (a[i] <= 399) 
            {
                if (!existGrey)
                {
                existGrey = true; 
                cnt++; 
                Console.Error.WriteLine("grey");
                }
            }
            else if (a[i] <= 799) 
            {
                if (!existBrown)
                {
                existBrown = true; 
                cnt++; 
                Console.Error.WriteLine("brown");
                }
            }
            else if (a[i] <= 1199) 
            {
                if (!existGreen)
                {
                existGreen = true; 
                cnt++; 
                Console.Error.WriteLine("green");
                }
            }
            else if (a[i] <= 1599) 
            {
                if (!existLightBlue)
                {
                existLightBlue = true; 
                cnt++; 
                Console.Error.WriteLine("lblue");
                }
            }
            else if (a[i] <= 1999) 
            {
                if (!existBlue)
                {
                existBlue = true; 
                cnt++; 
                Console.Error.WriteLine("blue");
                }
            }
            else if (a[i] <= 2399) 
            {
                if (!existYellow)
                {
                existYellow = true; 
                cnt++; 
                Console.Error.WriteLine("yellow");
                }
            }
            else if (a[i] <= 2799) 
            {
                if (!existOrange)
                {
                existOrange = true; 
                cnt++; 
                Console.Error.WriteLine("orange");
                }
            }
            else if (a[i] <= 3199) 
            {
                if (!existRed)
                {
                existRed = true; 
                cnt++; 
                Console.Error.WriteLine("red");
                }
            }
            else NumberOfFreeColorPerson++;
        }
        int min = Math.Max(cnt, 1);
        int max = min;
        if (NumberOfFreeColorPerson != 0) max = NumberOfFreeColorPerson + cnt;
        Console.WriteLine("{0} {1}", min, max);
    }
}
