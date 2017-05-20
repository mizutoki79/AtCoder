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
        string[] inputs = Console.ReadLine().Split(' ');
        int H = int.Parse(inputs[0]);
        int W = int.Parse(inputs[1]);
        string[] a = new string[H];
        for (int i = 0; i < H; i++)
        {
            a[i] = Console.ReadLine();
        }
        for (int i = -1; i < H + 1; i++)
        {
            Console.Write('#');
            if (i == -1 || i == H)
            {
                for (int j = 0; j < W; j++)
                {
                    Console.Write('#');
                }
            }
            else Console.Write(a[i]);
            Console.WriteLine('#');
        }
    }
}
