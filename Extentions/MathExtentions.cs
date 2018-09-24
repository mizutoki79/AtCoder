using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
static class MathExtensions
{
    public static long Factorial(long n)
    {
        var fact = n;
        for (var i = n - 1L; i >= 1L; i--)
        {
            fact *= i;
        }
        return fact;
    }

    public static long Combination(long n, long r)
    {
        var molecule = 1L;
        for (var i = 0L; i < r; i++) molecule *= n - i;
        var denominator = 1L;
        for (var i = r; i > 0; i--) denominator *= i;
        return molecule / denominator;
    }

    public static long Gcd(long a, long b)
    {
        var r = Math.Min(a, b);
        while (a != b && r != 0)
        {
            if (a > b) r = a %= b;
            else r = b %= a;
        }
        return Math.Max(a, b);
    }

    public static long Lcm(long a, long b)
    {
        return a * b / Gcd(a, b);
    }
}