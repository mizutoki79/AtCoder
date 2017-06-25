using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AtCoder.ABC065
{
    class Program
    {
        static int[] parent;
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n];
            int[] y = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(' ');
                x[i] = int.Parse(inputs[0]);
                y[i] = int.Parse(inputs[1]);
            }
            var sortedX = x.Select((elem, idx) => new { Value = elem, Index = idx })
                            .OrderBy(elem => elem.Value)
                            .ToArray();
            var sortedY = y.Select((elem, idx) => new { Value = elem, Index = idx })
                            .OrderBy(elem => elem.Value)
                            .ToArray();
            Edge[] edges = new Edge[2 * (n - 1)];
            int k = 0;
            for (int i = 1; i < n; i++)
            {
                edges[k++] = new Edge(sortedX[i - 1].Index, sortedX[i].Index, sortedX[i].Value - sortedX[i - 1].Value);
                edges[k++] = new Edge(sortedY[i - 1].Index, sortedY[i].Index, sortedY[i].Value - sortedY[i - 1].Value);
            }
            Array.Sort(edges);
            parent = Enumerable.Range(0, n).ToArray();
            long totalCost = 0;
            for (int i = 0; i < k; i++)
            {
                if (Root(edges[i].NodeId1) != Root(edges[i].NodeId2))
                {
                    totalCost += edges[i].Cost;
                    int theirRoot = Math.Min(Root(edges[i].NodeId1), Root(edges[i].NodeId2));
                    parent[parent[edges[i].NodeId1]] = theirRoot;
                    parent[parent[edges[i].NodeId2]] = theirRoot;
                }
            }
            Console.WriteLine(totalCost);
        }

        static int Root(int id)
        {
            return parent[id] == id ? id : parent[id] = Root(parent[id]);
        }
    }

    class Edge : IComparable<Edge>
    {
        public int NodeId1 { get; }
        public int NodeId2 { get; }
        public long Cost { get; }
        public Edge(int id1, int id2, long cost)
        {
            NodeId1 = id1;
            NodeId2 = id2;
            Cost = cost;
        }
        public int CompareTo(Edge edge2)
        {
            return this.Cost.CompareTo(edge2.Cost);
        }
    }
}