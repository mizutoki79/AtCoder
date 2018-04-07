using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC091.B
{
    class Program
    {
        static void Main ()
        {
            var sc = new Scanner ();
            int n = sc.nextInt ();
            var s = new string[n];
            for (int i = 0; i < n; i++)
            {
                s[i] = sc.next ();
            }
            int m = sc.nextInt ();
            var t = new string[m];
            for (int i = 0; i < m; i++)
            {
                t[i] = sc.next ();
            }

            var count = new Dictionary<string, int> ();
            foreach (var item in s)
            {
                if (count.ContainsKey (item)) count[item] += 1;
                else count.Add (item, 1);
            }
            foreach (var item in t)
            {
                if (count.ContainsKey (item)) count[item] -= 1;
            }
            Console.WriteLine (Math.Max (count.Values.Max (), 0));
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

        public string next ()
        {
            if (i < s.Length) return s[i++];
            string st = Console.ReadLine ();
            while (st == "") st = Console.ReadLine ();
            s = st.Split (cs, StringSplitOptions.RemoveEmptyEntries);
            if (s.Length == 0) return next ();
            i = 0;
            return s[i++];
        }

        public int nextInt ()
        {
            return int.Parse (next ());
        }
        public int[] ArrayInt (int N, int add = 0)
        {
            int[] Array = new int[N];
            for (int i = 0; i < N; i++)
            {
                Array[i] = nextInt () + add;
            }
            return Array;
        }

        public long nextLong ()
        {
            return long.Parse (next ());
        }

        public long[] ArrayLong (int N, long add = 0)
        {
            long[] Array = new long[N];
            for (int i = 0; i < N; i++)
            {
                Array[i] = nextLong () + add;
            }
            return Array;
        }

        public double nextDouble ()
        {
            return double.Parse (next ());
        }

        public double[] ArrayDouble (int N, double add = 0)
        {
            double[] Array = new double[N];
            for (int i = 0; i < N; i++)
            {
                Array[i] = nextDouble () + add;
            }
            return Array;
        }

        public decimal nextDecimal ()
        {
            return decimal.Parse (next ());
        }

        public decimal[] ArrayDecimal (int N, decimal add = 0)
        {
            decimal[] Array = new decimal[N];
            for (int i = 0; i < N; i++)
            {
                Array[i] = nextDecimal ();
            }
            return Array;
        }
    }
}