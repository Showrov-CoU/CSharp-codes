//Write programs using conditional statements and loops:
//Test for prime numbers.

using System;
namespace testprime
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, counter;
            Console.Write("Enter number [enter '-1' for stop execution]:");
            num = int.Parse(Console.ReadLine());

            while (num != -1)
            {

                for (counter = 2; counter <= num / 2; counter++)
                {
                    if ((num % counter) == 0)
                        break;
                }
                if (num == 1 || num == 0)
                    Console.WriteLine(num + " is neither prime nor composite");
                else if (counter <= (num / 2))
                    Console.WriteLine(num + " is not prime number");
                else
                    Console.WriteLine(num + " is prime number");

                Console.Write("Enter number [enter '-1' for stop execution]:");
                num = int.Parse(Console.ReadLine());
            }
            Console.ReadLine(); //to hold the screen
        }
    }
}