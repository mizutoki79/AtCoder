using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace AtCoder.ATC001.B
{
    class Program
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int n = int.Parse(inputs[0]);
            int q = int.Parse(inputs[1]);
            bool[] p = new bool[q];
            int[] a = new int[q];
            int[] b = new int[q];
            for (int i = 0; i < q; i++)
            {
                inputs = Console.ReadLine().Split(' ');
                p[i] = inputs[0] == "0" ? false : true;
                a[i] = int.Parse(inputs[1]);
                b[i] = int.Parse(inputs[2]);
            }

            UnionFind uf = new UnionFind(n);
            for (int i = 0; i < q; i++)
            {
                if (p[i])
                {
                    string ans = uf.IsSame(a[i], b[i]) ? "Yes" : "No";
                    Console.WriteLine(ans);
                }
                else
                {
                    uf.Unite(a[i], b[i]);
                }
            }
        }
    }

    public class UnionFind
    {
        private int[] parent;
        private int[] rank;

        public UnionFind() : this(int.MaxValue) {}

        public UnionFind(int n)
        {
            this.parent = new int[n];
            this.rank = new int[n];
            Initialize(n);
        }

        void Initialize(int n)
        {
            this.parent = Enumerable.Range(0, n).ToArray();
            this.rank = Enumerable.Repeat(0, n).ToArray();
        }

        int RootOf(int x)
        {
            return this.parent[x] == x ? x : this.parent[x] = RootOf(this.parent[x]);
        }

        public bool IsSame(int x, int y)
        {
            Console.Error.WriteLine($"parent[{x}] = {this.parent[x]} parent[{y}] = {this.parent[y]}");
            return RootOf(x) == RootOf(y);
        }

        public void Unite(int x, int y)
        {
            x = RootOf(x);
            y = RootOf(y);
            if (x == y) return;
            if (this.rank[x] < this.rank[y])
            {
                this.parent[x] = y;
            }
            else
            {
                this.parent[y] = x;
                if (this.rank[x] == this.rank[y]) this.rank[x]++;
            }
            Console.Error.WriteLine($"parent[{x}] = {this.parent[x]} parent[{y}] = {this.parent[y]}");
        }
    }
}