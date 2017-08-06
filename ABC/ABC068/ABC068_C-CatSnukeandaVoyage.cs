using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AtCoder.ABC068
{
    class Program
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            var connectList = Enumerable.Range(0, n + 1).Select(i => new List<int>()).ToArray();
            for (int i = 0; i < m; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                int a = int.Parse(inputs[0]);
                int b = int.Parse(inputs[1]);
                connectList[a].Add(b);
                connectList[b].Add(a);
            }
            var result = "IMPOSSIBLE";
            var common = connectList[1].Intersect(connectList[n]).ToArray();
            if (common.Length > 0) result = "POSSIBLE";
            Console.WriteLine(result);
        }
    }
}