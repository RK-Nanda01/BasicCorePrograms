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
            Console.WriteLine("MENU:->");
            Console.WriteLine("1. FlipCoin");
            Console.WriteLine("2. LeapYear");
            Console.WriteLine("3. Print Powers of 2");
            Console.WriteLine("4. Print Nth Harmonic");
            Console.WriteLine("5. Print Factors of a Number");
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
                case 3:
                    {
                        int n;
                        Console.WriteLine("Power of 2");
                        Console.WriteLine("Enter value of n");
                        n = Convert.ToInt32(Console.ReadLine());
                        if(n >= 31 || n<0 )
                        {
                            Console.WriteLine("Enter n between 0 and 31");
                        }
                        else
                        {
                            PowerOf2 p = new PowerOf2();
                            p.PrintPowersOfTwo(n);
                        }
                        
                        break;

                    }
                case 4:
                    {
                        int n;
                        double res;
                        Console.WriteLine("Printing Nth Harmonic");
                        Console.WriteLine("Enter value of n");
                        n = Convert.ToInt32(Console.ReadLine());
                        if (n < 0)
                        {
                            Console.WriteLine("Enter positive n");
                        }
                        else
                        {
                            Harmonic h = new Harmonic();
                            res= h.PrintHarmonic(n);
                            Console.WriteLine($"Nth Harmonic in decimal is {1 / res}");
                            Console.WriteLine($"Nth Harmonic in fraction is 1 / {res}");
                        }

                        break;

                    }
                case 5:
                    {
                        int n;
                        Console.WriteLine("Printing Factors of a Number");
                        Console.WriteLine("Enter value of n");
                        n = Convert.ToInt32(Console.ReadLine());
                        if (n < 0)
                        {
                            Console.WriteLine("Enter positive n");
                        }
                        else
                        {
                            Factors f = new Factors();
                            f.PrintFactors(n);
                            Console.WriteLine("");
                        }

                        break;

                    }

            }

        }

    }
}

