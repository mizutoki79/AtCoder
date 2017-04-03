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
        long[] A = new long[n];
        long[] B = new long[n];
        for (int i = 0; i < n; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            A[i] = long.Parse(inputs[0]);
            B[i] = long.Parse(inputs[1]);
        }

        long cnt = 0;
        for (int i = n - 1; i >= 0 ; i--)
        {
            long r = (A[i] + cnt) % B[i];
            if(r != 0) cnt += B[i] - r;
            Console.Error.WriteLine("{0} -> {1} : {2}", A[i], A[i] + cnt, B[i]);
            Console.Error.WriteLine("cnt = {0}", cnt);
        }
        Console.WriteLine(cnt);
    }
}