using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
 
class Program{
    static void Main(){
        int n = int.Parse(Console.ReadLine());
        int[] T = Console.ReadLine().Split(' ')
                                         .Select(val => int.Parse(val))
                                         .ToArray();
        int[] A = Console.ReadLine().Split(' ')
                                         .Select(val => int.Parse(val))
                                         .ToArray();
        long pat = 1;
        for (int i = 0; i < n; i++)
        {
            if((i == 0 || T[i - 1] != T[i]) && T[i] > A[i]){
                Console.WriteLine(0);
                return;
            }
            if((i == n - 1 || A[i] != A[i + 1]) && T[i] < A[i]){
                Console.WriteLine(0);
                return;
            }
            if(i != 0 && i != n - 1 && T[i - 1] == T[i] && A[i] == A[i + 1]){
                pat = pat * Math.Min(T[i], A[i]) % (long)(1e9 + 7);
            }
        }
        Console.WriteLine(pat);
    }
}
