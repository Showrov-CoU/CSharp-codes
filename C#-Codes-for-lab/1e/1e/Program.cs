//Write programs using conditional statements and loops:
// Generate prime numbers.

using System;
namespace testprime
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter, lowerlimit, upperlimit, limitCounter;
            Console.Write("Enter lower limit:");
            lowerlimit = int.Parse(Console.ReadLine());
            Console.Write("Enter upper limit:");
            upperlimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime number between " + lowerlimit + " and " + upperlimit + " are ");
            for (limitCounter = lowerlimit; limitCounter <= upperlimit; limitCounter++)
            {
                for (counter = 2; counter <= limitCounter / 2; counter++)
                {
                    if ((limitCounter % counter) == 0)
                        break;
                }
                if (limitCounter == 1)
                    Console.WriteLine(limitCounter + "is neither prime nor composite");
                else if (counter > (limitCounter / 2))
                    Console.WriteLine(limitCounter + "\t");
            }
            Console.WriteLine();
            Console.ReadLine();//to hold the screen
        }
    }
}