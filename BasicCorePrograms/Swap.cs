using System;
namespace BasicCorePrograms
{
	public class Swap
	{
        public void SwapNumbers(ref int x, ref int y)
        {
            int temp;
            temp = x; 
            x = y;    
            y = temp;

        }
    }
}

