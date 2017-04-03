import java.io.*;
import java.util.*;

class Q2{
	public static void main(String[] args){
		int n, m, answer = 0;
		Scanner sc = new Scanner(System.in);
		int check, count = 0;
		n = sc.nextInt();
		m = sc.nextInt();
		int[] A = new int[n];
		for(int i = 0; i < n; i++){
			A[i] = sc.nextInt();
		}
		for(int i = 0; i < A.length; i++){
			check = A[i];
			count = 0;
			for(int j = 0; j < A.length; j++){
				if(check == A[j]){
					count++;
				}
			}
			if(count > n / 2){
				 answer = A[i];
				 break;
			}
		}
		if(count > n / 2){
			System.out.println(answer);
		}
		else{
			System.out.println("?");
		}
	}
}