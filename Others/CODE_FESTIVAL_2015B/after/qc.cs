using System;
using System.Collections;
class qc{
	public static void Main(){
		string[] strNM = Console.ReadLine().Split(' ');
		int N = int.Parse(strNM[0]);
		int M = int.Parse(strNM[1]);
		if(N < M){
			Console.WriteLine("NO");
			return;
		}
		string[] strA = Console.ReadLine().Split(' ');
		int[] A = new int[N];
		int Mnum;
		for (int i = 0; i < N; i++)
		{
			A[i] = int.Parse(strA[i]);
		}
		string[] strB = Console.ReadLine().Split(' ');
		int[] B = new int[M];
		for (int i = 0; i < M; i++)
		{
			B[i] = int.Parse(strB[i]);
		}
		Array.Sort(A);
		Array.Sort(B);
		for (Mnum = 0; Mnum < M; Mnum++)
		{
			if ((A[N - Mnum - 1] >= B[M - Mnum - 1]))
			{
				continue;
			}
			else
			{
				break;
			}
		}
		if(Mnum == M ){
			Console.WriteLine("YES");
		}
		else{
			Console.WriteLine("NO");
		}
	}
}