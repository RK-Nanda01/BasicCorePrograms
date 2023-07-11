namespace BasicCorePrograms;
class Program
{
    static void Main(string[] args)
    {
        int option;
        Console.WriteLine("Basic Core Programs");
        Console.WriteLine($"Enter option:");
        option = Convert.ToInt32(Console.ReadLine());


        switch(option)
        {
            case 1:
                {
                    FlipCoin f = new FlipCoin();
                    f.FindPercentage();
                    break;
                }


        }
       


    }
}

