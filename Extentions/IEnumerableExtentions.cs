using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
static class IEnumerableExtensions
{
    public static long Nearest (this IEnumerable<long> self, long target)
    {
        var min = self.Min (val => Math.Abs (val - target));
        return self.First (val => Math.Abs (val - target) == min);
    }
}