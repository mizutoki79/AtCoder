using System;

class QB{
	public static void Main(){
		string[] str = Console.ReadLine().Split(' ');
		int N = int.Parse(str[0]);
		int M = int.Parse(str[1]);
		int[] A = new int[N];
		int[] count = new int[M + 1];
		string[] str2 = Console.ReadLine().Split(' ');
		for (int i = 0; i < N; i++)
		{
			A[i] = int.Parse(str2[i]);
			count[ A[i] ]++;
			if (count[ A[i] ] > N / 2)
			{
				Console.WriteLine(A[i]);
				return;
			}
		}
		Console.WriteLine("?");
	}
}