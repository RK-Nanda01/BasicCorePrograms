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
            Console.WriteLine("6. Print Quotient and Remainder");
            Console.WriteLine("7. Swap Two Numbers");
            Console.WriteLine("8. Check If Number is Even Or Odd");
            Console.WriteLine("9. Check If Vowel or Not");
            Console.WriteLine("10.Find Largest Of 3 Numbers");
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
                            Console.WriteLine($"Nth Harmonic in decimal is {res}");
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
                case 6:
                    {
                        int n;
                        int div;
                        int[] res;
                        Console.WriteLine("Finding Quotient and Remainder");
                        Console.WriteLine("Enter value of n");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter value of div");
                        div = Convert.ToInt32(Console.ReadLine());
                        if (div == 0)
                        {
                            Console.WriteLine("div should not be 0");
                        }
                        else
                        {
                            QuotientRem q = new QuotientRem();
                            res = q.GetQuoAndRem(n,div);
                            Console.WriteLine($"Quotient is {res[0]}");
                            if (res[1]<0)
                            {
                                Console.WriteLine($"Remainder is {div - res[1]}");

                            }
                            else
                            {
                                Console.WriteLine($"Remainder is {res[1]}");
                            }
                        }

                        break;

                    }
                case 7:
                    {
                        int num1;
                        int num2;
                        
                        Console.WriteLine("Swapping Two Numbers");
                        Console.WriteLine("Enter value of num1");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter value of num2");
                        num2 = Convert.ToInt32(Console.ReadLine());
                       
                        Console.WriteLine("Before Swapping:->");
                        Console.WriteLine($"Num1:->{num1}");
                        Console.WriteLine($"Num2:->{num2}");
                       
                        Swap s = new Swap();
                        s.SwapNumbers(ref num1, ref num2);
                        Console.WriteLine($"After Swapping:->");
                        Console.WriteLine($"Num1:->{num1}");
                        Console.WriteLine($"Num2:->{num2}");

                       
                    

                        break;

                    }
                case 8:
                    {
                        int num1;
                        bool res;
                        Console.WriteLine("Checking If number is Even Or Odd");
                        Console.WriteLine("Enter value of num1");
                        num1 = Convert.ToInt32(Console.ReadLine());
                       
                       
                        EvenOdd e = new EvenOdd();
                        res = e.IfEven(num1);
                       if(res)
                        {
                            Console.WriteLine($"{num1} Is Even");
                        }
                       else
                        {
                            Console.WriteLine($"{num1} Is Odd");
                        }
  
                        break;

                    }
                case 9:
                    {
                        string a;
                        bool res;
                        Console.WriteLine("Checking If Char is Vowel or Consonant");
                        Console.WriteLine("Enter value of a");
                        a = Console.ReadLine();
                        VowelConsonant v = new VowelConsonant();
                        res = v.IsVowel(a);
                        if (res)
                        {
                            Console.WriteLine($"{a} Is Vowel");
                        }
                        else
                        {
                            Console.WriteLine($"{a} Is Consonant");
                        }

                        break;

                    }
                case 10:
                    {
                        int x, y, z;
                        int res;
                        Console.WriteLine("Finding Largest of 3");
                        Console.WriteLine("Enter value of x");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter value of y");
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter value of z");
                        z = Convert.ToInt32(Console.ReadLine());
                        Largest l = new Largest();
                        res = l.LargestOfThree(x,y,z);
                        Console.WriteLine($"The largest of {x} , {y} , {z} is {res}");
                        break;

                    }

            }

        }

    }
}

