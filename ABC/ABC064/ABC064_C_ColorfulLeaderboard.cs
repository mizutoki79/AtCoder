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
        const int NumOfColors = 8;
        bool[] colors = new bool[NumOfColors];
        int NumberOfFreeColor = 0;
        for (int i = 0; i < n; i++)
        {
            if (a[i] >= 3200) 
            {
                NumberOfFreeColor++;
                continue;
            }
            for (int j = 0; j < NumOfColors; j++)
            {
                if (!colors[j] && 400 * j <= a[i] && a[i] < 400 * (j + 1))
                {
                    colors[j] = true;
                }
            }
        }
        int cnt = colors.Where(elem => elem).Count();
        int min = Math.Max(1, cnt);
        int max = cnt + NumberOfFreeColor;
        Console.WriteLine("{0} {1}", min, max);
    }
}