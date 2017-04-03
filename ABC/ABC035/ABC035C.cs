using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtCoderSharp
{
    class main
    {
        static void Main()
        {
            int N, Q;
            int l, r;
            int[] S;
            string[] str = Console.ReadLine().Split(' ');
            N = int.Parse(str[0]);
            Q = int.Parse(str[1]);
            S = new int[N + 1];
            for (int i = 0; i < Q; i++)
            {
                str = Console.ReadLine().Split(' ');
                l = int.Parse(str[0]);
                r = int.Parse(str[1]);
                S[l - 1]++;
                S[r]--;
            }
            for (int i = 0; i < N; i++)
            {
                S[i + 1] += S[i];
                if (S[i] % 2 == 0) S[i] = 0;
                else S[i] = 1;
            }
            for(int i = 0; i< N; i++)
            {
                Console.Write(S[i]);
            }
            Console.WriteLine();
        }
    }
}
