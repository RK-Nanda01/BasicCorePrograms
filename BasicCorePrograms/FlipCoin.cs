using System;
namespace BasicCorePrograms
{
	public class FlipCoin
	{
		public void FindPercentage()
		{
			int times;
			double head = 0;
            double tail = 0;
			double headPercentage = 0;
			Random rn = new Random();
            Console.WriteLine("Implementing Flip Coin");
			Console.WriteLine("Enter Number of times you want to flip the coin");
            times = Convert.ToInt32(Console.ReadLine());

			for(int i = 0; i<times;i++)
			{
				double number = rn.NextDouble();
				if(number < 0.5)
				{
					tail++;
				}
				else
				{
					head++;
				}
			}

			headPercentage = (head / times) * 100;
			Console.WriteLine($"% of occurance of Heads is {headPercentage}");
            Console.WriteLine($"% of occurance of Tails is {100 - headPercentage}");



        }
	}
}

