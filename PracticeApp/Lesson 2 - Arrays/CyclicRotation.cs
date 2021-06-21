using System;
namespace Codility
{
	public class CyclicRotation
	{
		public int[] solution(int[] A, int K)
		{
			var r = new int[A.Length];
			if (r.Length > 0)
			{
				//Console.WriteLine("(K % A.Length) = " + (K % A.Length));
				//Console.WriteLine("A.Length - (K % A.Length) = " + (A.Length - (K % A.Length)));
				for (int i = -1, j = A.Length - (K % A.Length); ++i < A.Length;)
				{
					//Console.WriteLine("i = " + i);
					//Console.WriteLine("(j + i) % A.Length = "+(j + i) % A.Length);
					r[i] = A[(j + i) % A.Length];
				}
			}
			return r;
		}

		public void Test() {
			int[] A = { 1, 2, 3, 4, 5}; int k = 3;
			A = solution(A, k);
			var str = String.Join(",", A);
			Console.WriteLine(str);
		}

		public void GettingArrayIndex() {
			int x = 5;
			for (int i = 1; i <= x; i++) {
				Console.WriteLine("my calc = x - (x - i)" + (i == x ? 0 : (x - (x - i))));
				Console.WriteLine("reminder = x % i" + (i % x));
			}
		}
	}

	/*
	 [1,2,3,4,5]
	  5-(1/5)= 5
	  5%5 = 0
	  6%5 =  

	 
	 */
}