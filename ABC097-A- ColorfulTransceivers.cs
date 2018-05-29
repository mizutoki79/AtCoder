using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC097.A
{
    class Program
    {
        static void Main ()
        {
            var sc = new Scanner ();
            int a = sc.NextInt ();
            int b = sc.NextInt ();
            int c = sc.NextInt ();
            int d = sc.NextInt ();
            if (Math.Abs (a - c) <= d || (Math.Abs (a - b) <= d && Math.Abs (b - c) <= d))
            {
                Console.WriteLine ("Yes");
                return;
            }
            Console.WriteLine ("No");
        }
    }

    class Scanner
    {
        string[] s;
        int i;

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

        public int NextInt ()
        {
            return int.Parse (Next ());
        }
        public int[] ArrayInt (int N, int add = 0)
        {
            int[] Array = new int[N];
            for (int i = 0; i < N; i++)
            {
                Array[i] = NextInt () + add;
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
            for (int i = 0; i < N; i++)
            {
                Array[i] = NextLong () + add;
            }
            return Array;
        }

        public double NextDouble ()
        {
            return double.Parse (Next ());
        }

        public double[] ArrayDouble (int N, double add = 0)
        {
            double[] Array = new double[N];
            for (int i = 0; i < N; i++)
            {
                Array[i] = NextDouble () + add;
            }
            return Array;
        }

        public decimal NextDecimal ()
        {
            return decimal.Parse (Next ());
        }

        public decimal[] ArrayDecimal (int N, decimal add = 0)
        {
            decimal[] Array = new decimal[N];
            for (int i = 0; i < N; i++)
            {
                Array[i] = NextDecimal ();
            }
            return Array;
        }
    }

    static class MathExtensions
    {
        public static long Factorial (int n)
        {
            long fact = n;
            for (int i = n - 1; i >= 1; i--)
            {
                fact *= i;
            }
            return fact;
        }

        static long Combination (int n, int r)
        {
            long molecule = 1;
            for (int i = 0; i < r; i++) molecule *= n - i;
            long denominator = 1;
            for (int i = 1; i <= r; i++) denominator *= i;
            return molecule / denominator;
        }
    }

    static class IEnumerableExtensions
    {
        public static long Nearest (this IEnumerable<long> self, long target)
        {
            var min = self.Min (val => Math.Abs (val - target));
            return self.First (val => Math.Abs (val - target) == min);
        }
    }
}