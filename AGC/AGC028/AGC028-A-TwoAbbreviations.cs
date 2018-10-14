using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.AGC028.A
{
    class Program
    {
        static void Main()
        {
            var sc = new Scanner();
            var n = sc.Nextint();
            var m = sc.Nextint();
            var s = sc.Next();
            var t = sc.Next();

            var lcm = Lcm(n, m);
            // Console.Error.WriteLine(lcm);
            var n2 = lcm / n;
            var m2 = lcm / m;
            var lcm2 = Lcm(n2, m2);
            var n3 = lcm2 / n2;
            var m3 = lcm2 / m2;
            var s2 = s.Where((ch, idx) => idx % n3 == 0).ToArray();
            // Console.Error.WriteLine(s2);
            var t2 = t.Where((ch, idx) => idx % m3 == 0).ToArray();
            // Console.Error.WriteLine(t2);
            for (int i = 0; i < Math.Min(s2.Length, t2.Length); i++)
            {
                if (s2[i] != t2[i])
                {
                    Console.WriteLine(-1);
                    return;
                }
            }
            Console.WriteLine(lcm);
        }

        public static long Gcd(long a, long b)
        {
            var r = Math.Min(a, b);
            while (a != b && r != 0)
            {
                if (a > b) r = a %= b;
                else r = b %= a;
            }
            return Math.Max(a, b);
        }

        public static long Lcm(long a, long b)
        {
            return a * b / Gcd(a, b);
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
