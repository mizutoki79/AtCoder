using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AtCoder.ABC067
{
    class Program
    {
        static HashSet<int>[] edge;
        static int[] distanceFromFennec;
        static int[] distanceFromSnuke;
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var a = new int[n];
            var b = new int[n];
            edge = Enumerable.Range(0, n).Select(i => new HashSet<int>()).ToArray();
            distanceFromFennec = new int[n];
            distanceFromSnuke = new int[n];
            for (int i = 0; i < n - 1; i++)
            {
                int[] inputs = Console.ReadLine().Split(' ')
                            .Select(elem => int.Parse(elem) - 1)
                            .ToArray();
                a[i] = inputs[0];
                b[i] = inputs[1];
                edge[a[i]].Add(b[i]);
                edge[b[i]].Add(a[i]);
                // for (int j = 0; j < n; j++) Console.Error.WriteLine("edge[{0}]: {1}", j, string.Join(" ", edge[j]));
            }

            DistanceFrom(0, 1, distanceFromFennec);
            DistanceFrom(n - 1, 1, distanceFromSnuke);
            // Console.Error.WriteLine("from Fennec: {0}", string.Join(" ", distanceFromFennec));
            // Console.Error.WriteLine("from Snuke: {0}", string.Join(" ", distanceFromSnuke));
            int cnt1 = 0, cnt2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (distanceFromFennec[i] <= distanceFromSnuke[i]) cnt1++;
                else cnt2++;
            }
            // Console.Error.WriteLine("cnt1:{0}, cnt2:{1}", cnt1, cnt2);
            Console.WriteLine(cnt1 > cnt2 ? "Fennec" : "Snuke");
        }

        static void DistanceFrom(int n, int d, int[] dp)
        {
            if (dp[n] != 0) return;
            dp[n] = d++;
            // Console.Error.WriteLine("{0}:{1} {2}", n, d - 1, string.Join(" ", edge[n]));
            foreach (var item in edge[n])
            {
                DistanceFrom(item, d, dp);
            }
        }
    }
}