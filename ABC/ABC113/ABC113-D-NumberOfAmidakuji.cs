using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC113.D
{
    class Program
    {
        static void Main()
        {
            var sc = new Scanner();
            var H = sc.Nextint();
            var W = sc.Nextint();
            var K = sc.Nextint() - 1;
            var mod = (long) 1e9 + 7;

            var modPatterns = new long[H, W];
            for (int i = H - 1; i >= 0; i--)
            {
                for (int j = 0; j < W; j++)
                {
                    if (i == H - 1)
                    {
                        if (j == K)
                        {
                            modPatterns[i, j] = (j != 0 && j != W - 1) ? W - 2 : W - 1;
                        }
                        else if (Math.Abs(K - j) == 1)
                        {
                            modPatterns[i, j] = 1;
                        }
                    }
                    else
                    {
                        modPatterns[i, j] = ((j != 0 && j != W - 1) ? (W - 2) * modPatterns[i + 1, j] : (W - 1) * modPatterns[i + 1, j]) % mod;
                        if (j != 0) modPatterns[i, j] += modPatterns[i + 1, j - 1];
                        if (j != W - 1) modPatterns[i, j] += modPatterns[i + 1, j + 1];
                        modPatterns[i, j] %= mod;
                    }
                }
            }
            if (modPatterns[0, 0] == 0) modPatterns[0, 0] = 1;
            Console.WriteLine(modPatterns[0, 0]);
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
