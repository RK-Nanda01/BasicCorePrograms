using System;
namespace BasicCorePrograms
{
	public class QuotientRem
	{
		public int [] GetQuoAndRem(int n,int div)
		{
			int[] res = { 0,0};

			res[0] = n / div;
			res[1] = n % div;
			return res;
		}
	}
}

