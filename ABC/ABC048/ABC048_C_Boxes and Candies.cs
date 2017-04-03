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
        long[] inputs = Console.ReadLine().Split(' ')
                                    .Select(val => long.Parse(val))
                                    .ToArray();
        int n = (int)inputs[0];
        long x = inputs[1];
        long[] a = Console.ReadLine().Split(' ')
                                     .Select(val => long.Parse(val))
                                     .ToArray();
        long cnt = 0;
        if(a[0] > x)
        {
            long dif = a[0] - x;
            a[0] = x;
            cnt += dif;
        }
        for(int i = 0; i < n - 1; i++)
        {
            long dif = a[i] + a[i + 1] - x;
            if(dif > 0)
            {
                a[i + 1] -= dif;
                cnt += dif;
            }
        }
        Console.WriteLine(cnt);
    }
}
