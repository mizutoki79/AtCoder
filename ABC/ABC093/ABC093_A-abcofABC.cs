using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC093.A
{
    class Program
    {
        static void Main ()
        {
            var s = new string (Console.ReadLine ().OrderBy (elem => elem).ToArray ());
            Console.Error.WriteLine (s);
            Console.WriteLine (s == "abc" ? "Yes" : "No");
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
}