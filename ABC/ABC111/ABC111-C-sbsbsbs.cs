using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC111.C
{
    class Program
    {
        static void Main()
        {
            var sc = new Scanner();
            var n = sc.Nextint();
            var v = sc.Arrayint(n);

            var evenElems = new List<int>(n / 2);
            var oddElems = new List<int>(n / 2);
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) evenElems.Add(v[i]);
                else oddElems.Add(v[i]);
            }
            var evenElemCount = new Dictionary<int, int>();
            var oddElemCount = new Dictionary<int, int>();

            foreach (var item in evenElems)
            {
                if (!evenElemCount.ContainsKey(item)) evenElemCount.Add(item, 1);
                else evenElemCount[item]++;
            }
            foreach (var item in oddElems)
            {
                if (!oddElemCount.ContainsKey(item)) oddElemCount.Add(item, 1);
                else oddElemCount[item]++;
            }

            var sortedEvenElemCount = evenElemCount.OrderByDescending(elem => elem.Value);
            var sortedOddElemCount = oddElemCount.OrderByDescending(elem => elem.Value);
            // Console.Error.WriteLine(string.Join(" ", sortedEvenElemCount));
            // Console.Error.WriteLine(string.Join(" ", sortedOddElemCount));
            if (sortedEvenElemCount.First().Key != sortedOddElemCount.First().Key)
            {
                var evenChangeCount = sortedEvenElemCount.Skip(1).Sum(elem => elem.Value);
                var oddChangeCount = sortedOddElemCount.Skip(1).Sum(elem => elem.Value);
                var totalChangeCount = evenChangeCount + oddChangeCount;
                Console.WriteLine(totalChangeCount);
                return;
            }
            else
            {
                if (sortedEvenElemCount.ElementAtOrDefault(1).Value >= sortedOddElemCount.ElementAtOrDefault(1).Value)
                {
                    var evenChangeCount = sortedEvenElemCount.Where((elem, idx) => idx != 1).Sum(elem => elem.Value);
                    var oddChangeCount = sortedOddElemCount.Skip(1).Sum(elem => elem.Value);
                    var totalChangeCount = evenChangeCount + oddChangeCount;
                    Console.WriteLine(totalChangeCount);
                    return;
                }
                else
                {
                    var evenChangeCount = sortedEvenElemCount.Skip(1).Sum(elem => elem.Value);
                    var oddChangeCount = sortedOddElemCount.Where((val, idx) => idx != 1).Sum(elem => elem.Value);
                    var totalChangeCount = evenChangeCount + oddChangeCount;
                    Console.WriteLine(totalChangeCount);
                    return;
                }
            }
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
