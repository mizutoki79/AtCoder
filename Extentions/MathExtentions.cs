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
        if (r > n - r) return Combination(n, n - r);
        var molecule = 1L;
        for (var i = 0L; i < r; i++) molecule *= n - i;
        var denominator = 1L;
        for (var i = r; i > 0; i--) denominator *= i;
        return molecule / denominator;
    }

    public static long ModCombination(long n, long r, int divisor)
    {
        if (r > n - r) return ModCombination(n, n - r, divisor);
        var molecule = 1L;
        var denominator = 1L;
        for (var i = 0L; i < r; i++)
        {
            molecule *= n - i;
            molecule %= divisor;
            denominator *= i + 1;
            molecule %= divisor;
        }
        return molecule * ModPow(denominator, divisor - 2, divisor) % divisor;
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

    public static bool IsPrime(int n)
    {
        for (int i = 2; i * i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static long ModPow(long value, int power, int divisor)
    {
        if (power == 0) return 1L;
        if (power % 2 == 0)
        {
            int halfPower = power / 2;
            long halfResult = ModPow(value, halfPower, divisor);
            return halfResult * halfResult % divisor;
        }
        else
        {
            return value * ModPow(value, power - 1, divisor) % divisor;
        }
    }

    public static IEnumerable<long> FibonacciSequence()
    {
        var a = 0L;
        var b = 1L;
        while (true)
        {
            yield return a;
            yield return b;
            a += b;
            b += a;
        }
    }
}
