using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
 
class Program{
    static bool[,] reached;
    static int h;
    static int w;

    static void Main(){
        string[] inputs = Console.ReadLine().Split(' ');
        h = int.Parse(inputs[0]);
        w = int.Parse(inputs[1]);
        var maze = new char[h][];
        reached = new bool[w, h];
        int sx = 0, sy = 0, gx = 0, gy = 0;
        bool sfound = false, gfound = false;
        int sidx = 0, gidx = 0;
        for(int i = 0; i < h; i++){
            string line = Console.ReadLine();
            if(!sfound) sidx = line.IndexOf('s');
            if(!gfound) gidx = line.IndexOf('g');
            if(!sfound && sidx != -1){
                sx = sidx;
                sy = i;
                sfound = true;
            }
            if(!gfound && gidx != -1){
                gx = gidx;
                gy = i;
                gfound = true;
            }
            maze[i] = new char[w];
            line.ToCharArray().CopyTo(maze[i], 0);
        }
        Search(maze, sx, sy);
        if(reached[gx, gy]) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }

    static void Search(char[][] maze, int x, int y){
        if(x < 0 || w <= x || y < 0 || h <= y || maze[y][x] == '#') return;
        if(reached[x, y] || reached[gx, gy]) return;
        reached[x, y] = true;
        Search(maze, x + 1, y);
        Search(maze, x - 1, y);
        Search(maze, x, y + 1);
        Search(maze, x, y - 1);
    }
}