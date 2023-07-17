using System;
namespace BasicCorePrograms
{
	public class Harmonic
	{
		public double PrintHarmonic(int n)
		{
			double res = 1;
			for(double i = 2; i<=n; i++)
			{
				res += 1 / i;
			}
			return res;
		}
	}
}

