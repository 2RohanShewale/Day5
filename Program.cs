using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Xml.Serialization;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            do
            {
                System.Console.WriteLine();
                System.Console.WriteLine("***::::Basic Core Programs::::***");

                ListOfPrograms();
                System.Console.Write("Enter Choice(in number): ");
                choice = Convert.ToInt32(System.Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FlipCoin();
                        break;
                    case 2:
                        LeapYear();
                        break;
                    case 3:
                        PowerOfTwo();
                        break;
                    case 4:
                        HarmonicNumbers();
                        break;
                    case 5:
                        Factors();
                        break;
                    case 6:
                        SwapNumbers();
                        break;
                    case 7:
                        EvenOrOdd();
                        break;
                    case 8:
                        QuotientAndRemainder();
                        break;
                    case 9:
                        VowelOrConsonent();
                        break;
                    case 10:
                        LargestAmongThree();
                        break;

                }
            } while (choice != 0);
                

            System.Console.ReadKey();
        }

        static void ListOfPrograms()
        {
            System.Console.WriteLine("1. Flip Coin and percentage of Heads and tells");
            System.Console.WriteLine("2. Leap Year");
            System.Console.WriteLine("3. Power of 2");
            System.Console.WriteLine("4. Harmonic number");
            System.Console.WriteLine("5. Factors");
            System.Console.WriteLine("6. Swap Two Numbers");
            System.Console.WriteLine("7. Even or Odd");
            System.Console.WriteLine("8. Quotient Or Numbers");
            System.Console.WriteLine("9. Vowel Or Consonentd");
            System.Console.WriteLine("10.Largest Among Three Numbers");
            System.Console.WriteLine("0. To Exit");

        }

        static void FlipCoin()
        {
            int choice = -1;
            do
            {
                System.Console.WriteLine();
                System.Console.WriteLine("*****Coin flip and Percentage of Heads and Tails Program*****");
                System.Console.WriteLine("Enter a number (Coin will flip number of times you want)");
                int number = Convert.ToInt32(System.Console.ReadLine());
                if (number > 0)
                {
                    float headsCount = 0;
                    float tailsCount = 0;
                    Random random = new Random();
                    for (int i = 0; i < number; i++)
                    {


                        int rand = random.Next(2);
                        if (rand < 0.5)
                        {
                            System.Console.WriteLine("Tails");
                            tailsCount += 1;

                        }
                        else
                        {
                            System.Console.WriteLine("Heads");
                            headsCount += 1;
                        }

                    }
                    float percentage = (headsCount / tailsCount) * 100;
                    System.Console.WriteLine("Heads vs Tails percentage: " + percentage + "%");
                }
                else
                {
                    System.Console.WriteLine("Plase Enter Positive Number");
                }
                choice = PlayAgain();

            } while (choice != 0);
        }


        static void LeapYear()
        {
            int choice = -1;
            do
            {
                System.Console.WriteLine();
                System.Console.WriteLine("******Leap Year Program******");
                System.Console.Write("Enter a year: ");
                int year = Convert.ToInt32(System.Console.ReadLine());
                if (year > 0)
                {
                    if (year%4 != 0)
                    {
                        System.Console.WriteLine(year + " is not a leap Year");

                    }
                    else
                    {
                        if (year%100 != 0)
                        {
                            System.Console.WriteLine(year + " is a leap year");
                        }
                        else
                        {
                            if (year%400 == 0)
                            {
                                System.Console.WriteLine(year + " is a leap year");
                            }
                            else
                            {
                                System.Console.WriteLine(year + " is not a leap year");
                            }
                        }
                    }
                }
                else
                {
                    System.Console.WriteLine("You can only enter positive year");
                }
                choice = PlayAgain();
            } while (choice != 0);
        }

        static void QuotientAndRemainder()
        {
            int choice = -1;
            do
            {   
                System.Console.WriteLine();
                System.Console.WriteLine("*****Quotient And Remainder*****");
                System.Console.Write("Enter A Divident: ");
                int divident = Convert.ToInt32(System.Console.ReadLine());
                System.Console.Write("Enter A Divisor: ");
                int divisor = Convert.ToInt32(System.Console.ReadLine());
                
                int quotient = divident / divisor;
                int remainder = divident % divisor;

                System.Console.WriteLine("Quotient: " + quotient);
                System.Console.WriteLine("Remainder: " + remainder);
                choice = PlayAgain();
            } while (choice != 0);
        }

        static void VowelOrConsonent()
        {
            int choice = -1;
            do
            {
                System.Console.WriteLine();
                System.Console.WriteLine("*****Vowel Or Consonants*****");
                System.Console.Write("Enter a alphaber character: ");
                char alpha = System.Console.ReadLine()[0];
                string vowel = "aeiouAEIOU";
                bool b1 = true;
                foreach (char c in vowel)
                {
                    if (alpha == c)
                    {
                        b1 = false;
                        break;
                    }

                }
                if (b1)
                {
                    System.Console.WriteLine(alpha + " is a consonant");
                }
                else
                {
                    System.Console.WriteLine(alpha + " is a Vowel.");
                }
                choice = PlayAgain();
            } while (choice != 0);
        }

        static void LargestAmongThree()
        {
            int choice = -1;
            do
            {
                System.Console.WriteLine();
                System.Console.WriteLine("*****Largest Among Three*****");
                System.Console.Write("Enter first Number: ");
                int num1 = Convert.ToInt32(System.Console.ReadLine());
                System.Console.Write("Enter second Number: ");
                int num2 = Convert.ToInt32(System.Console.ReadLine());
                System.Console.Write("Enter third Number: ");
                int num3 = Convert.ToInt32(System.Console.ReadLine());

                int max = 0;

                if (num1 > max) { max = num1; }
                if (num2> max) { max = num2; }
                if (num3> max) { max = num3; }

                System.Console.WriteLine("The largest number is " + max);

                choice = PlayAgain();
            } while (choice != 0);
        }
        static void EvenOrOdd()
        {
            int choice = -1;
            do
            {
                System.Console.WriteLine();
                System.Console.WriteLine("*****Even Or Odd*****");
                System.Console.Write("Enter a number: ");
                int num = Convert.ToInt32(System.Console.ReadLine());

                if (num%2 == 0) { System.Console.WriteLine(num + " is even number"); }
                else { System.Console.WriteLine(num +" is Odd number");  }
                choice = PlayAgain();
            } while (choice != 0);
        }

        static void SwapNumbers()
        {
            int choice = -1;
            do
            {
                System.Console.WriteLine();
                System.Console.WriteLine("*****Swap Numbers*****");
                System.Console.WriteLine("Enter numbers");
                System.Console.Write("A: ");
                int a = Convert.ToInt32(System.Console.ReadLine());
                System.Console.Write("B: ");
                int b = Convert.ToInt32(System.Console.ReadLine());

                int c = a;
                a = b;
                b = c;

                System.Console.WriteLine("After Swap");

                System.Console.WriteLine("A: " + a);
                System.Console.WriteLine("B: " + b);
                choice = PlayAgain();
            } while (choice != 0);
        }

        static void PowerOfTwo()
        {
            int choice = -1;
            do
            {
                System.Console.WriteLine();
                System.Console.WriteLine("*****Power Of Two*****");
                System.Console.Write("Enter a number that will be largest of two: ");
                int n = Convert.ToInt32(System.Console.ReadLine());
                if (n >= 0 & n < 31)
                {
                    int val = 0;
                    for (int i = 0; i <= n; i++)
                    {
                        if (i == 0) { System.Console.WriteLine ('0'); }
                        else if(i == 1) { val += 2; System.Console.WriteLine(val); }
                        else { val *= 2; System.Console.WriteLine(val); }    
                    }
                }
                else { System.Console.WriteLine("Please only enter number from 0 to 30"); }
                choice = PlayAgain();
            } while (choice != 0);
        }

        static void HarmonicNumbers()
        {
            int choice = -1;
            do
            {
                System.Console.WriteLine();
                System.Console.WriteLine("*****Find Nth Harmonic Number*****");
                System.Console.Write("Enter a number(n): ");
                int n = Convert.ToInt32(System.Console.ReadLine());
                if (n != 0)
                {
                    float harmonic = 0;
                    for (float i = 1; i <= n; i++)
                    {
                        float num = (1f / i);
                        harmonic += num;
                    }
                    System.Console.WriteLine("The " + n + "th harmonic value is " + harmonic);
                }
                else
                {
                    System.Console.WriteLine("You cant enter 0");
                }
                
                choice= PlayAgain();
            } while (choice != 0);
        }

        static void Factors()
        {
            int choice = -1;
            do
            {
                System.Console.WriteLine();
                System.Console.WriteLine("*****Factors*****");
                System.Console.Write("Enter a number: ");
                int num = Convert.ToInt32(System.Console.ReadLine());
                System.Console.WriteLine("Prime factors of " + num + " are: ");

                while (num%2 == 0)
                {
                    System.Console.WriteLine(2);
                    num = num / 2;
                }
                double root = Math.Sqrt(num);
                for (int i = 3; i < root; i+=2)
                {
                    while (num%i == 0)
                    {
                        num /= i;
                        System.Console.WriteLine(i);
                    }
                }
                choice = PlayAgain();
            } while (choice != -1);
        }
        static int PlayAgain()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("0. to exit");
            System.Console.WriteLine("1. to Try Again");
            System.Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(System.Console.ReadLine());
            return choice;
        }

    }

}
