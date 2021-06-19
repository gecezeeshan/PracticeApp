using System;
namespace Codility
{
	public
class CountDiv
	{
		public int solution(int A, int B, int K)
		{
			var mod = A % K;
			return (mod == 0 ? 1 : 0) + (B + mod - A) / K;
		}
	}
}