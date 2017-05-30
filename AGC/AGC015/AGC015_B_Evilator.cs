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
        string S = Console.ReadLine();
        int top = S.Length - 1;
        long cnt = 0;
        for (int i = 0; i < top; i++)
        {
            if (S[i] == 'U') cnt += (top - i) + 2 * (i - 1);
            else cnt += 2 * (top - i) + (i - 1);
        }
        Console.WriteLine(cnt);
    }
}
