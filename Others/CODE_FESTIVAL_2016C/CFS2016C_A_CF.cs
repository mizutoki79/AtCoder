using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
 
class Program{
    static void Main(){
        string s = Console.ReadLine();
        bool flag = false;
        int i = s.IndexOf('C');
        if(i != -1){
            if(s.IndexOf('F', i) != -1){
                flag = true;
            }
        }
        Console.WriteLine(flag ? "Yes" : "No");
    }
}