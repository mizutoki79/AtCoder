//mcs main.mcs - compile
//mono main.exe - run
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class Program{
    static void Main(){
        const int keyNum = 12;
        const string template = "WBWBWWBWBWBW";
        string[] keys = {"Do", "#", "Re", "#", "Mi", "Fa", "#", "So", "#", "La", "#", "Si"};
        string s = Console.ReadLine();
        int idxOfDo = s.IndexOf(template);
        int idxOfAns = idxOfDo != 0 ? keyNum - idxOfDo : 0;
        if(idxOfDo == -1) idxOfAns = 2;
        Console.WriteLine(keys[idxOfAns]);
    }
}