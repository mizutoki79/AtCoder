using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder
{
    class Program
    {
        static void Main()
        {
            var sc = new Scanner();
            var S = sc.Next();
            var N = S.Length;
            const double mod = 1e9 + 7;
            var indexes = Enumerable.Range(0, 8).Select(_ => new List<int>()).ToArray();
            var counts = new double[8];
            for (int i = N - 1; i >= 0; i--)
            {
                var item = S[i];

                switch (item)
                {
                    case 'i':
                        counts[7] += 1;
                        break;
                    case 'a':
                        counts[6] = (counts[6] + counts[7]) % mod;
                        break;
                    case 'd':
                        counts[5] = (counts[5] + counts[6]) % mod;
                        break;
                    case 'u':
                        counts[4] = (counts[4] + counts[5]) % mod;
                        break;
                    case 'k':
                        counts[3] = (counts[3] + counts[4]) % mod;
                        break;
                    case 'o':
                        counts[2] = (counts[2] + counts[3]) % mod;
                        break;
                    case 'h':
                        counts[1] = (counts[1] + counts[2]) % mod;
                        break;
                    case 'c':
                        counts[0] = (counts[0] + counts[1]) % mod;
                        break;
                }
            }
            Console.WriteLine(counts[0]);
        }
    }

    class Scanner
    {
        string[] s;
        long i;

        char[] cs = new char[] { ' ' };

        public Scanner()
        {
            s = new string[0];
            i = 0;
        }

        public string Next()
        {
            if (i < s.Length) return s[i++];
            string st = Console.ReadLine();
            while (st == "") st = Console.ReadLine();
            s = st.Split(cs, StringSplitOptions.RemoveEmptyEntries);
            if (s.Length == 0) return Next();
            i = 0;
            return s[i++];
        }

        public string[] Array(int N)
        {
            var Array = new string[N];
            for (int i = 0; i < N; i++)
            {
                Array[i] = Next();
            }
            return Array;
        }

        public int Nextint()
        {
            return int.Parse(Next());
        }
        public int[] Arrayint(int N, int add = 0)
        {
            int[] Array = new int[N];
            for (int i = 0; i < N; i++)
            {
                Array[i] = Nextint() + add;
            }
            return Array;
        }

        public long NextLong()
        {
            return long.Parse(Next());
        }

        public long[] ArrayLong(int N, long add = 0)
        {
            long[] Array = new long[N];
            for (long i = 0; i < N; i++)
            {
                Array[i] = NextLong() + add;
            }
            return Array;
        }

        public double NextDouble()
        {
            return double.Parse(Next());
        }

        public double[] ArrayDouble(long N, double add = 0)
        {
            double[] Array = new double[N];
            for (long i = 0; i < N; i++)
            {
                Array[i] = NextDouble() + add;
            }
            return Array;
        }

        public decimal NextDecimal()
        {
            return decimal.Parse(Next());
        }

        public decimal[] ArrayDecimal(long N, decimal add = 0)
        {
            decimal[] Array = new decimal[N];
            for (long i = 0; i < N; i++)
            {
                Array[i] = NextDecimal();
            }
            return Array;
        }
    }
}
