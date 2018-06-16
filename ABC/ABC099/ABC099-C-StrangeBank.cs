using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC099.C
{
    class Program
    {
        static void Main ()
        {
            Console.WriteLine (Solve (int.Parse (Console.ReadLine ())).Min ());
        }
        static IEnumerable<int> Solve (int n)
        {
            for (var i = 0; i <= n; i++)
            {
                var j = n - i;
                var cnt6 = Enumerable.Range (0, i)
                    .Select (p => Math.Pow (6, p))
                    .TakeWhile (val => val <= i)
                    .Select (val => Math.Floor (i / val) % 6)
                    .Sum (val => (int) val);
                var cnt9 = Enumerable.Range (0, j)
                    .Select (p => Math.Pow (9, p))
                    .TakeWhile (val => val <= j)
                    .Select (val => Math.Floor (j / val) % 9)
                    .Sum (val => (int) val);
                yield return cnt6 + cnt9;
            }
        }
    }
    class Scanner
    {
        string[] s;
        long i;

        char[] cs = new char[] { ' ' };

        public Scanner ()
        {
            s = new string[0];
            i = 0;
        }

        public string Next ()
        {
            if (i < s.Length) return s[i++];
            string st = Console.ReadLine ();
            while (st == "") st = Console.ReadLine ();
            s = st.Split (cs, StringSplitOptions.RemoveEmptyEntries);
            if (s.Length == 0) return Next ();
            i = 0;
            return s[i++];
        }

        public int Nextint ()
        {
            return int.Parse (Next ());
        }
        public int[] Arrayint (int N, int add = 0)
        {
            int[] Array = new int[N];
            for (int i = 0; i < N; i++)
            {
                Array[i] = Nextint () + add;
            }
            return Array;
        }

        public long NextLong ()
        {
            return long.Parse (Next ());
        }

        public long[] ArrayLong (int N, long add = 0)
        {
            long[] Array = new long[N];
            for (long i = 0; i < N; i++)
            {
                Array[i] = NextLong () + add;
            }
            return Array;
        }

        public double NextDouble ()
        {
            return double.Parse (Next ());
        }

        public double[] ArrayDouble (long N, double add = 0)
        {
            double[] Array = new double[N];
            for (long i = 0; i < N; i++)
            {
                Array[i] = NextDouble () + add;
            }
            return Array;
        }

        public decimal NextDecimal ()
        {
            return decimal.Parse (Next ());
        }

        public decimal[] ArrayDecimal (long N, decimal add = 0)
        {
            decimal[] Array = new decimal[N];
            for (long i = 0; i < N; i++)
            {
                Array[i] = NextDecimal ();
            }
            return Array;
        }
    }
}