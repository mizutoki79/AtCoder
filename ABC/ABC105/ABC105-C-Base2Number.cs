using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC105.C
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(Decimal2MinusBinaryNumber(n));
        }

        static string Decimal2MinusBinaryNumber(int num)
        {
            string minusBinaryNumber = null;
            while (num != 0)
            {
                if (num % (-2) != 0)
                {
                    num--;
                    minusBinaryNumber = "1" + minusBinaryNumber;
                }
                else minusBinaryNumber = "0" + minusBinaryNumber;
                num /= (-2);
            }
            return minusBinaryNumber ?? "0";
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