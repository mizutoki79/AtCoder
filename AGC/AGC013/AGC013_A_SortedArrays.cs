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
        int n = int.Parse(Console.ReadLine());
        int[] inputs = Console.ReadLine().Split(' ')
                    .Select(elem => int.Parse(elem))
                    .ToArray();
        int counter = 1;
        if(n == 1) 
        {
            Console.WriteLine(1);
            return;
        }
        bool isAscending = false, isDescending = false;
        if(inputs[0] < inputs[1]) isAscending = true;
        else if(inputs[0] > inputs[1]) isDescending = true;
        for (int i = 2; i < n; i++)
        {
            if(isAscending && !(inputs[i - 1] <= inputs[i]))
            {
                isAscending = false;
                isDescending = false;
                counter++;
            }
            else if(isDescending && !(inputs[i - 1] >= inputs[i]))
            {
                isAscending = false;
                isDescending = false;
                counter++;
            }
            else if(!isAscending && !isDescending)
            {
                if(inputs[i - 1] < inputs[i]) isAscending = true;
                else if(inputs[i - 1] > inputs[i]) isDescending = true;
            }
            else continue;
        }
        Console.WriteLine(counter);
    }
}