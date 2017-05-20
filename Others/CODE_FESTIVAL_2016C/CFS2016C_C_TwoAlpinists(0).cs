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
        int[] dT = new int[n];
        List<int> iT = new List<int>();
        int[] dA = new int[n];
        List<int> iA = new List<int>();
        for (int i = 0; i < n; i++)
        {
            if(i == 0){
                dT[i] = T[i];
                iT.Add(i);
            }
            else if(i == n - 1){
                dA[i] = A[i];
                iA.Add(i);
            }
            else{
                if(T[i - 1] != T[i]){
                    dT[i] = T[i];
                    iT.Add(i);
                }
                if(A[i] != A[i + 1]){
                    dA[i] = A[i];
                    iA.Add(i);
                }
            }
        }
        Console.Error.WriteLine("iT: {0}", string.Join(" ", iT));
        Console.Error.WriteLine("iA: {0}", string.Join(" ", iA));
        bool contra = false;
        foreach (int idx in iT)
        {
            Console.Error.WriteLine("T idx: {0}", idx);
            if(dT[idx] > A[idx] || (dA[idx] != 0 && dT[idx] != dA[idx])) contra = true;
            if(contra) break;
        }
        foreach (int idx in iA)
        {
            Console.Error.WriteLine("A idx: {0}", idx);
            if(dT[idx] != 0){
                if(dA[idx] > T[idx] || dT[idx] != dA[idx]) contra = true;
            }
            else {
                iT.Add(idx);
                dT[idx] = 1;
            }
            if(contra) break;
            
        }
        Console.Error.WriteLine("iT + iA: {0}", string.Join(" ", iT));
        long pat = 1;
        if(!contra){
            for(int i = 0; i < n; i++){
                if(dT[i] != 0) continue;
                else pat *= T[i] <= A[i] ? T[i] : A[i];
                pat %= (long)Math.Pow(10, 9) + 7;
                Console.Error.WriteLine("i:{0} pat:{1}", i, pat);
            }
        }
        else pat = 0;
        Console.WriteLine(pat);

    }
}
