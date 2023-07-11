namespace BasicCorePrograms;
class Program
{
    static void Main(string[] args)
    {
        int option;
        Console.WriteLine("Basic Core Programs");
        bool flag = true;
        while(flag)
        {
            Console.WriteLine("1. FlipCoin");
            Console.WriteLine("2. LeapYear");
            Console.WriteLine("0. Exit");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 0:
                    {
                        flag = false;
                        break;
                    }
                case 1:
                    {
                        FlipCoin f = new FlipCoin();
                        f.FindPercentage();
                        break;
                    }

                case 2:
                    {
                        int year;
                        bool res;
                        Console.WriteLine("Checking If Leap Year");
                        Console.WriteLine("Enter year to check");
                        year = Convert.ToInt32(Console.ReadLine());
                        LeapYear l1 = new LeapYear();
                        res = l1.CheckLeapYear(year);
                        if (res)
                        {
                            Console.WriteLine($"{year} is a Leap Year");
                        }
                        else
                        {
                            Console.WriteLine($"{year} is Not a Leap Year");
                        }
                        break;

                    }

            }

        }

    }
}

