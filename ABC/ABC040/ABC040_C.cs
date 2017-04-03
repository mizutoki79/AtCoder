//mcs main.mcs - compile
//mono main.exe - run
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class Program{
    static void Main(){
        int N = int.Parse(Console.ReadLine());
        var a = Array.ConvertAll(Console.ReadLine().Split(' '), new Converter<string,int>(int.Parse));
        var dp = (new int[N]).Select(value => int.MaxValue).ToArray();
        dp[0] = 0;
        for(int i = 0; i < N - 1; i++){
            if(i + 1 < N) dp[i + 1] = Math.Min(dp[i + 1], dp[i] + Math.Abs(a[i] - a[i + 1]));
            if(i + 2 < N) dp[i + 2] = Math.Min(dp[i + 2], dp[i] + Math.Abs(a[i] - a[i + 2]));
        }
        Console.WriteLine(dp[N - 1]);
    }
}