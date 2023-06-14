//Write programs using conditional statements and loops:
// Generate Fibonacci series
using System;
namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1, num3, num4, num, counter;
            Console.Write("Upto how many number you want fibonacci series:");
            num = int.Parse(Console.ReadLine());
            counter = 3;
            Console.Write(num1 + "\t" + num2);
            while (counter <= num)
            {
                num3 = num1 + num2;

                Console.Write("\t" + num3);

                num1 = num2;
                num2 = num3;
                counter++;
            }
            Console.ReadLine();
        }
    }
}