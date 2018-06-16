using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC100.D
{
    class Program
    {
        static void Main ()
        {
            var sc = new Scanner ();
            var n = sc.Nextint ();
            var m = sc.Nextint ();
            var x = new long[n];
            var y = new long[n];
            var z = new long[n];
            for (var i = 0; i < n; i++)
            {
                x[i] = sc.NextLong ();
                y[i] = sc.NextLong ();
                z[i] = sc.NextLong ();
            }

            var max = 0L;
            for (var i = 0; i < 8; i++)
            {
                var values = new long[n];
                for (var j = 0; j < n; j++)
                {
                    if ((i & 4) > 0) values[j] -= x[j];
                    else values[j] += x[j];
                    if ((i & 2) > 0) values[j] -= y[j];
                    else values[j] += y[j];
                    if ((i & 1) > 0) values[j] -= z[j];
                    else values[j] += z[j];
                }
                max = Math.Max (max, values.OrderByDescending (val => val).Take (m).Sum ());
                Console.Error.WriteLine (max);
            }
            Console.WriteLine (max);
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