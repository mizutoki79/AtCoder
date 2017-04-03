using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
 
class Program{
    static void Main(){
        string[] inputs = Console.ReadLine().Split(' ');
        int n = int.Parse(inputs[0]);
        int a = int.Parse(inputs[1]);
        int b = int.Parse(inputs[2]);
        char[] s = Console.ReadLine().ToCharArray();
        int pass = 0;
        int passb = 0;
        for(int i = 0; i < s.Length; i++){
            if(pass < (a + b) && s[i] == 'a'){
                Console.WriteLine("Yes");
                pass++;
            }
            else if(pass < (a + b) && s[i] == 'b'){
                if(passb < b){
                    Console.WriteLine("Yes");
                    pass++;
                    passb++;
                }
                else{
                    Console.WriteLine("No");
                }
            }
            else{
                Console.WriteLine("No");
            }
        }
    }
}