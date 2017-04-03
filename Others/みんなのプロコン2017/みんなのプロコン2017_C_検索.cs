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
        int n = int.Parse(inputs[0]);
        int k = int.Parse(inputs[1]);
        int[] A = Console.ReadLine().Split(' ')
                    .Select(elem => int.Parse(elem) - 1)
                    .ToArray();
        bool[] isSearch = new bool[n];
        for(int i = 0; i < k; i++) isSearch[A[i]] = true;
        string[] S = new String[n];
        for (int i = 0; i < n; i++) S[i] = Console.ReadLine();
        List<string> searchList = new List<string>();
        List<string> unsearchList = new List<string>();
        for (int i = 0; i < n; i++)
        {
            if(isSearch[i]) searchList.Add(S[i]);
            else unsearchList.Add(S[i]);
        }

        string commonWord = GetLongestCommonSubstring(searchList);
        int wordLength = 0;
        for (int i = 0; i < unsearchList.Count; i++)
        {
            string conflict = GetLongestCommonSubstring(unsearchList[i], commonWord);
            Console.Error.WriteLine("conflict {0}", conflict);
            if(wordLength <= conflict.Length) wordLength = conflict.Length + 1;
            if(commonWord.Length == conflict.Length)
            {
                wordLength = commonWord.Length + 10;
                break;
            }
        }
        Console.Error.WriteLine("CW.Length {0}, WL {1}", commonWord.Length, wordLength);
        Console.Error.WriteLine("commonWord {0}", commonWord);
        string searchWord = wordLength <= commonWord.Length ? commonWord.Substring(0, wordLength) : "-1";
        Console.WriteLine(searchWord);
    }

    static string GetLongestCommonSubstring(List<string> originList)
    {
        string common = originList.OrderByDescending(elem => elem.Length)
                                .First();
        int commonLength = common.Length;
        for (int i = 0; i < originList.Count; i++)
        {
            string target = originList[i];
            if(target == common) continue;
            commonLength = GetLongestCommonSubstring(target, common).Length;
        }
        return common.Substring(0, commonLength);
    }
    private static string GetLongestCommonSubstring(string str1, string str2)
    {
        int limit = str1.Length <= str2.Length ? str1.Length : str2.Length;
        List<char> common = new List<char>();
        for (int i = 0; i < limit; i++)
        {
            if(str1[i] == str2[i]) common.Add(str1[i]);
            else break;
        }
        return new string(common.ToArray());
    }
}