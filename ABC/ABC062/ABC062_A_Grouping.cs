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
        int[][] groups = new int[3][];
        groups[0] = new int[]{1, 3, 5, 7, 8, 10, 12};
        groups[1] = new int[]{4, 6, 9, 11};
        groups[2] = new int[]{2};
        string[] inputs = Console.ReadLine().Split(' ');
        int x = int.Parse(inputs[0]);
        int y = int.Parse(inputs[1]);
        bool isSameGroup = false;
        for (int i = 0; i < groups.Length; i++)
        {
            if (groups[i].Contains(x) && groups[i].Contains(y))
            {
                isSameGroup = true;
                break;
            }
        }
        Console.WriteLine(isSameGroup ? "Yes" : "No");
    }
}
