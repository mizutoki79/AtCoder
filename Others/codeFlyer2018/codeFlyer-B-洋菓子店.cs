using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.codeFlyer.B
{
    class Program
    {
        static void Main ()
        {
            var sc = new Scanner ();
            var a = sc.Nextint ();
            var b = sc.Nextint ();
            var n = sc.Nextint ();
            var x = sc.Next ();
            foreach (var item in x)
            {
                switch (item)
                {
                    case 'S':
                        if (a > 0)
                        {
                            a--;
                        }
                        break;
                    case 'C':
                        if (b > 0)
                        {
                            b--;
                        }
                        break;
                    case 'E':
                        if (a == 0 && b == 0)
                        {
                            break;
                        }
                        else if (a >= b)
                        {
                            a--;
                        }
                        else
                        {
                            b--;
                        }
                        break;
                }
            }
            Console.WriteLine (a);
            Console.WriteLine (b);
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