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
        long H = long.Parse(inputs[0]);
        long W = long.Parse(inputs[1]);
        long result = 0;
        if(!(H % 3 == 0 || W % 3 == 0))
        {
            if(H > W)
            {
                long tmp = H;
                H = W;
                W = tmp;
            }
            long separatePoint = W / 2;
            long[] areas = new long[3];
            long areaGap = long.MaxValue;
            int i = 1;
            while (separatePoint > 0)
            {
                areas[0] = H * separatePoint;
                long H2 = H / 2, W2 = W - separatePoint;
                areas[1] = H2 * W2;
                areas[2] = (H - H2) * W2;
                Console.Error.WriteLine("1-{6} - H1: {0}, W1: {1}, H2: {2}, W2: {3}, H3: {4}, W3: {5}", H, separatePoint, H2, W2, H - H2, W2, i++);
                long compareAreaGap = areas.Max() - areas.Min();
                Console.Error.WriteLine("area1: {0}, area2: {1}, area3: {2}, gap: {3}", areas[0], areas[1], areas[2], compareAreaGap);
                if(areaGap > compareAreaGap)
                {
                    areaGap = compareAreaGap;
                    separatePoint--;
                    continue;
                }
                else break;
            }
            long tmp2 = H;
            H = W;
            W = tmp2;
            separatePoint = W / 2;
            long areaGap2 = long.MaxValue;
            i = 1;
            while (separatePoint > 0)
            {
                areas[0] = H * separatePoint;
                long H2 = H / 2, W2 = W - separatePoint;
                areas[1] = H2 * W2;
                areas[2] = (H - H2) * W2;
                Console.Error.WriteLine("2-{6} - H1: {0}, W1: {1}, H2: {2}, W2: {3}, H3: {4}, W3: {5}", H, separatePoint, H2, W2, H - H2, W2, i++);
                long compareAreaGap = areas.Max() - areas.Min();
                Console.Error.WriteLine("area1: {0}, area2: {1}, area3: {2}, gap: {3}", areas[0], areas[1], areas[2], compareAreaGap);
                if(areaGap2 > compareAreaGap)
                {
                    areaGap2 = compareAreaGap;
                    separatePoint--;
                    continue;
                }
                else break;
            }
            result = Math.Min(areaGap, areaGap2);
            result = result > Math.Min(H, W) ? Math.Min(H, W) : result;
        }
        Console.WriteLine(result);
    }
}
