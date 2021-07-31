using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder
{
    class Program
    {
        static readonly Func<string> ReadLine = () => Console.ReadLine();
        static readonly Func<int> ReadInt = () => int.Parse(ReadLine());
        static private string[] ReadArray() => ReadLine().Split(' ');
        static private T[] ReadArray<T>(Func<string, T> parser) => ReadArray().Select(parser).ToArray();
        static private T Id<T>(T x) => x;
        static private void EPrint1D<T>(IEnumerable<T> seq) => Console.Error.WriteLine("[{0}]", string.Join(", ", seq));
        static private void EPrint2D<T>(IEnumerable<IEnumerable<T>> seq2d) => seq2d.ForEach(seq => EPrint1D(seq));
        static void Main()
        {
            var (N, M, _) = ReadArray(int.Parse);
            var A = ReadArray(int.Parse).Distinct().OrderBy(Id).ToArray();
            var B = ReadArray(int.Parse).Distinct().OrderBy(Id).ToArray();
            var min = int.MaxValue;
            var i = 0;
            var j = 0;
            while(i < A.Length && j < B.Length)
            {
                var a = A[i];
                var b = B[j];
                min = Math.Min(min, Math.Abs(a - b));
                if (a < b)
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }
            Console.WriteLine(min);
        }
    }

    public static class IEnumerableExtension
    {
        public static void Deconstruct<T>(this IList<T> self, out T first, out T second, out IList<T> rest)
        {
            first = self.Count > 0 ? self[0] : default;
            second = self.Count > 1 ? self[1] : default;
            rest = self.Skip(2).ToArray();
        }

        public static void ForEach<T>(this IEnumerable<T> self, Action<T> action)
        {
            foreach (T item in self)
            {
                action(item);
            }
        }
    }
}
