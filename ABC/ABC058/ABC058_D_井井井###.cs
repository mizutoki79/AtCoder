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
        const long Divisor = 1000000007;
        string[] inputs = Console.ReadLine().Split(' ');
        int n = int.Parse(inputs[0]);
        int m = int.Parse(inputs[1]);
        int[] x = Console.ReadLine().Split(' ')
                        .Select(int.Parse)
                        .OrderBy(elem => elem)
                        .ToArray();
        int[] y = Console.ReadLine().Split(' ')
                        .Select(int.Parse)
                        .OrderBy(elem => elem)
                        .ToArray();

        long totalArea = 0, areaX = 0, areaY = 0;
        for (int i = 1; i < n; i++)
        {
            areaX += (long)(x[i] - x[i - 1]) * i % Divisor * (n - i) % Divisor;
            areaX %= Divisor;
        }
        for (int i = 1; i < m; i++)
        {
            areaY += (long)(y[i] - y[i - 1]) * i % Divisor * (m - i) % Divisor;
            areaY %= Divisor;
        }
        totalArea = areaX * areaY % Divisor;
        
        Console.WriteLine(totalArea);
    }
}