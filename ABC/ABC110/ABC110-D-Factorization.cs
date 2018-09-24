using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC110.D
{
    class Program
    {
        static void Main()
        {
            var sc = new Scanner();
            var n = sc.Nextint();
            var m = sc.Nextint();

            const int divisor = (int) 1e9 + 7;
            var mLeft = m;
            var ans = 1L;
            for (int i = 2; i * i <= mLeft; i++)
            {
                if (mLeft % i == 0)
                {
                    var cnt = 0;
                    while (mLeft % i == 0)
                    {
                        cnt++;
                        mLeft /= i;
                    }
                    ans *= ModCombination(cnt + n - 1, n - 1, divisor);
                    ans %= divisor;
                }
            }
            if (mLeft != 1)
            {
                ans *= ModCombination(1 + n - 1, n - 1, divisor);
                ans %= divisor;
            }
            Console.WriteLine(ans);
        }

        public static long ModCombination(long n, long r, int devisor)
        {
            if (r > n - r) return ModCombination(n, n - r, devisor);
            var molecule = 1L;
            var denominator = 1L;
            for (var i = 0L; i < r; i++)
            {
                molecule *= n - i;
                molecule %= devisor;
                denominator *= i + 1;
                denominator %= devisor;
            }
            return molecule * ModPow(denominator, devisor - 2, devisor) % devisor;
        }

        public static long ModPow(long value, int power, int devisor)
        {
            if (power == 0) return 1L;
            if (power % 2 == 0)
            {
                int halfPower = power / 2;
                long halfResult = ModPow(value, halfPower, devisor);
                return halfResult * halfResult % devisor;
            }
            else
            {
                return value * ModPow(value, power - 1, devisor) % devisor;
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