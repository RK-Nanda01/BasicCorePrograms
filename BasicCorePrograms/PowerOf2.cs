using System;
namespace BasicCorePrograms
{
	public class PowerOf2
	{
		public void PrintPowersOfTwo(int n)
		{
			for(int i = 0; i<=n; i++)
			{
				Console.WriteLine($"2 to the power {i} is {Math.Pow(2, i)}");
			}

		}
	}
}

