using System;

namespace Codility
{
	public class FrogJmp
	{
		public int solution(int X, int Y, int D)
		{
			return (int)Math.Ceiling(((double)Y - X) / D);
		}
	}
}