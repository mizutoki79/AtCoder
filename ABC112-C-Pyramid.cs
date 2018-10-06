using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC112.C
{
    class Program
    {
        static void Main()
        {
            var sc = new Scanner();
            var n = sc.Nextint();
            var x = new int[n];
            var y = new int[n];
            var h = new long[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = sc.Nextint();
                y[i] = sc.Nextint();
                h[i] = sc.NextLong();
            }

            for (var cx = x.Min(); cx <= x.Max(); cx++)
                for (var cy = y.Min(); cy <= y.Max(); cy++)
                {
                    var H = -1L;
                    // Console.Error.WriteLine($"({cx} {cy})");
                    for (var i = 0; i < n; i++)
                    {
                        if (h[i] != 0)
                        {
                            var tmpH = HeightOfCenter(x[i], y[i], h[i], cx, cy);
                            // Console.Error.WriteLine($"H: {H}, tmp: {tmpH}");
                            if (H == -1L) H = tmpH;
                            else if (H != tmpH) break;
                        }
                        if (i == n - 1)
                        {
                            if (H == -1L) H = 0L;
                            Console.WriteLine($"{cx} {cy} {H}");
                            return;
                        }
                    }
                }
        }

        static long HeightOfCenter(int x, int y, long h, int cx, int cy)
        {
            return h + Math.Abs(x - cx) + Math.Abs(y - cy);
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