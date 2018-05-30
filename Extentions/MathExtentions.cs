using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
static class MathExtensions
{
    public static long Factorial (long n)
    {
        long fact = n;
        for (long i = n - 1; i >= 1; i--)
        {
            fact *= i;
        }
        return fact;
    }

    static long Combination (long n, long r)
    {
        long molecule = 1;
        for (long i = 0; i < r; i++) molecule *= n - i;
        long denominator = 1;
        for (long i = 1; i <= r; i++) denominator *= i;
        return molecule / denominator;
    }
}