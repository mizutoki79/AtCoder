using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AtCoder.ABC096.C
{
    class Program
    {
        static void Main ()
        {
            var sc = new Scanner ();
            int h = sc.NextInt ();
            int w = sc.NextInt ();
            var square = new char[h][];
            for (int i = 0; i < h; i++)
            {
                square[i] = Console.ReadLine ().ToCharArray ();
            }
            var isReachable = new bool[h, w];
            // var stk = new Stack<(int, int)>();
            var stk = new Stack<Pair<int, int>> ();
            //

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    int y = i, x = j;
                    if (square[y][x] == '.' || isReachable[y, x]) continue;
                    do
                    {
                        // if(stk.Count > 0) (y, x) = stk.Pop();
                        if (stk.Count > 0)
                        {
                            var tmp = stk.Pop ();
                            y = tmp.Item1;
                            x = tmp.Item2;
                        }
                        //

                        if (x + 1 < w && square[y][x + 1] == '#')
                        {
                            isReachable[y, x] = true;
                            // if (!isReachable[y, x + 1]) stk.Push((y, x + 1));
                            if (!isReachable[y, x + 1])
                            {
                                var tmp = new Pair<int, int> (y, x + 1);
                                stk.Push (tmp);
                            }
                            // 

                            isReachable[y, x + 1] = true;
                        }
                        if (y + 1 < h && square[y + 1][x] == '#')
                        {
                            isReachable[y, x] = true;
                            // if (!isReachable[y + 1, x]) stk.Push((y + 1, x));
                            if (!isReachable[y + 1, x])
                            {
                                var tmp = new Pair<int, int> (y + 1, x);
                                stk.Push (tmp);
                            }
                            // 

                            isReachable[y + 1, x] = true;
                        }
                        // Console.Error.WriteLine($"y:{y} x:{x} stack count:{stk.Count()}");
                    } while (stk.Count > 0);
                }
            }

            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    // Console.Error.WriteLine($"square[{i}][{j}] = {square[i][j]} isReachable[{i},{j}] = {isReachable[i, j]}");
                    if (square[i][j] == '#' && !isReachable[i, j])
                    {
                        Console.WriteLine ("No");
                        return;
                    }
                }
            }
            Console.WriteLine ("Yes");
            return;
        }

    }

    //
    class Pair<T1, T2>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public Pair (T1 item1, T2 item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
    }
    //

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