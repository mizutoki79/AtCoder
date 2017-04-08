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
        const int NumOfAlp = 26;
        int n = int.Parse(Console.ReadLine());
        int[][] count = new int[NumOfAlp][];
        for(int i = 0; i < NumOfAlp; i++) count[i] = new int[n];
        for (int i = 0; i < n; i++)
        {
            string S = Console.ReadLine();
            for (int j = 0; j < S.Length; j++)
            {
                count[(int)(S[j] - 'a')][i]++;
            }
        }
        for (int i = 0; i < NumOfAlp; i++)
        {
            IEnumerable<char> result = Enumerable.Repeat((char)('a' + i), count[i].Min());
            foreach (char item in result)
            {
                Console.Write(item);
            }
        }
        Console.WriteLine();
    }
}