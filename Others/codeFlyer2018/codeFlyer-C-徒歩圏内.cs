using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
// RE or TLE
namespace AtCoder.codeFlyer.C
{
    class Program
    {
        static void Main ()
        {
            var sc = new Scanner ();
            var n = sc.Nextint ();
            var d = sc.NextLong ();
            var x = sc.ArrayLong (n);

            var isWalkLocationsHigh = Enumerable.Range (0, n).Select (i => new List<int> ()).ToArray ();
            var isWalkLocationsLow = Enumerable.Range (0, n).Select (i => new List<int> ()).ToArray ();
            var isTrain = new bool[n, n];
            for (var i = 0; i < n; i++)
            {
                for (var j = i; j < n; j++)
                {
                    if (Math.Abs (x[i] - x[j]) <= d)
                    {
                        isWalkLocationsHigh[i].Add (j);
                        isWalkLocationsLow[j].Add (i);
                    }
                    else
                        isTrain[i, j] = true;
                }
            }
            var count = 0;
            for (var j = 1; j < n - 1; j++)
            {
                foreach (var i in isWalkLocationsLow[j])
                {
                    foreach (var k in isWalkLocationsHigh[j])
                    {
                        if (isTrain[i, k])
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine (count);
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