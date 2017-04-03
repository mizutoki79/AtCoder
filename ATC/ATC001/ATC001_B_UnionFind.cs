using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
 
class Program{
    static void Main(){
        string[] inputs = Console.ReadLine().Split(' ');
        int n = int.Parse(inputs[0]);
        int q = int.Parse(inputs[1]);
        bool[] p = new bool[q];
        int[] a = new int[q];
        int[] b = new int[q];
        for(int i = 0; i < q; i++){
            inputs = Console.ReadLine().Split(' ');
            p[i] = inputs[0] == "0" ? false : true;
            a[i] = int.Parse(inputs[1]);
            b[i] = int.Parse(inputs[2]);
        }

        UnionFind uf = new UnionFind(n);
        for(int i = 0; i < q; i++){
            if(p[i]){
                string ans = uf.IsSame(a[i], b[i]) ? "Yes" : "No";
                Console.WriteLine(ans);
            }
            else{
                uf.Unite(a[i], b[i]);
            }
        }
    }
}

public class UnionFind{
    static int[] parent;
    static int[] rank;

    public UnionFind(): this(int.MaxValue){}

    public UnionFind(int n){
        parent = new int[n];
        rank = new int[n];
        Initialize(n);
    }

    void Initialize(int n){
        for(int i = 0; i < n; i++){
            parent[i] = i;
            rank[i] = 0;
        }
    }

    int RootOf(int x){
        return parent[x] == x ? x : parent[x] = RootOf(parent[x]);
    }

    public bool IsSame(int x, int y){
        Console.Error.WriteLine("parent[{0}] = {2} parent[{1}] = {3}", x, y, parent[x], parent[y]);
        return RootOf(x) == RootOf(y);
    }

    public void Unite(int x, int y){
        x = RootOf(x);
        y = RootOf(y);
        if(x == y) return;
        if(rank[x] < rank[y]){
            parent[x] = y;
        }
        else{
            parent[y] = x;
            if(rank[x] == rank[y]) rank[x]++;
        }
        Console.Error.WriteLine("parent[{0}] = {2} parent[{1}] = {3}", x, y, parent[x], parent[y]);
    }
}