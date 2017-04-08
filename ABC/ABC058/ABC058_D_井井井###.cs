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
        long[] x = Console.ReadLine().Split(' ')
                        .Select(long.Parse)
                        .OrderBy(elem => elem)
                        .ToArray();
        long[] y = Console.ReadLine().Split(' ')
                        .Select(long.Parse)
                        .OrderBy(elem => elem)
                        .ToArray();

        long totalArea = 0;
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < m; j++)
            {
                long area = 0;
                //Console.Error.WriteLine("i: {0}, j:{1}", i, j);
                //Console.Error.WriteLine("x[i] - x[i - 1] = {0} - {1} = {2}", x[i], x[i - 1], x[i] - x[i - 1]);
                //Console.Error.WriteLine("y[j] - y[j - 1] = {0} - {1} = {2}", y[j], y[j - 1], y[j] - y[j - 1]);
                area = (x[i] - x[i - 1]) * (y[j] - y[j - 1]) % Divisor;
                //Console.Error.WriteLine("area = {0}", area);
                area = area * i * (n - i) % Divisor;
                //Console.Error.WriteLine(" * {0}", i * (n - i));
                area = area * j * (m - j) % Divisor;
                //Console.Error.WriteLine(" * {0}", j * (m - j));
                //Console.Error.WriteLine("totalArea = {0} + {1} = ", totalArea, area);
                totalArea = (totalArea + area) % Divisor;
                //Console.Error.WriteLine("{0}", totalArea);
            }
        }
        
        Console.WriteLine(totalArea);
    }
}