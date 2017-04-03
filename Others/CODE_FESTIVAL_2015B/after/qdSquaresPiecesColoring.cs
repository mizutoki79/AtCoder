using System;

class qdSquaresPiecesColoring{
	public static void Main(){
		int N = int.Parse(Console.ReadLine());
		double[] S = new double[N];
		double[] C = new double[N];
		double count;
		double loc;
		bool[,] black = new bool[10, 100]; 
		for (int i = 0; i < N; i++)
		{
			string[] strSC = Console.ReadLine().Split(' ');
			S[i] = double.Parse(strSC[0]);
			C[i] = double.Parse(strSC[1]);
		}
		for (int i = 0; i < N; i++)
		{
			count = 0;
			loc = S[i];
			while (black[(int)(loc % 10), (int)(Math.Log(loc, 10))] == false || count < C[i]){
				if(black[(int)(loc % 10), (int)(Math.Log(loc, 10))] == false) {
					black[(int)(loc % 10), (int)(Math.Log(loc, 10))] = true;
					count++;
				}
				if (count == C[i])
				{
					Console.WriteLine(loc);
					break;
				}
				loc++;
			}
		}
	}
}