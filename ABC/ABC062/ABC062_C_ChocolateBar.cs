using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
 
class Program
{
    static void Main()
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int H = int.Parse(inputs[0]);
        int W = int.Parse(inputs[1]);
        long result = 0;
        if (!(H % 3 == 0 || W % 3 == 0))
        {
            result = Math.Min(SearchMinimumDifference(H, W), SearchMinimumDifference(W, H));
            result = Math.Min(result, Math.Min(H, W));
        }
        Console.WriteLine(result);
    }

    static long SearchMinimumDifference(int H, int W)
    {
        long separatePoint = W / 3;
        long originalSeparatePoint = separatePoint;
        long difference = long.MaxValue;
        bool isIncrease = true;
        do
        {
            long newDifference = CalculateDifference(H, W, separatePoint);
            Console.Error.WriteLine(": {0}", newDifference);
            if (difference > newDifference)
            {
                difference = newDifference;
                if (isIncrease) separatePoint++;
                else separatePoint--;
            }
            else if (isIncrease)
            {
                separatePoint = originalSeparatePoint;
                isIncrease = false;
            }
            else break;
        } while (separatePoint > 0 && separatePoint <= W / 2);
        return difference;
    }

    static long CalculateDifference(int H, int W, long separatePoint)
    {
        long[] areas = new long[3];
        areas[0] = H * separatePoint;
        long H2 = H / 2, W2 = W - separatePoint;
        areas[1] = H2 * W2;
        areas[2] = (H - H2) * W2;
        Console.Error.WriteLine(string.Join(" ", areas));
        return areas.Max() - areas.Min();
    }
}
