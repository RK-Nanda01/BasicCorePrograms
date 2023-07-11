using System;
namespace BasicCorePrograms
{
	public class Factors
	{
		public void PrintFactors(int n)
		{
			
			if(n%2 == 0)
			{
				Console.Write("2 ");
				while(n%2 == 0)
				{
					n = n / 2;

				}
			}

			if(n%2!=0)
			{
				for(int i = 3; i<=Math.Sqrt(n); i+=2)
				{

					if(n%i == 0)
					{
                        Console.Write($"{i} ");
                        while (n % i == 0)
                        {

                            n = n / i;

                        }
                    }	
					
				}
			}

			if (n > 2)
			{
				Console.Write($"{n}");
			}





        }
	}
}

