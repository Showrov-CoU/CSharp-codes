using System;
namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            try
            {
                Console.Write("Enter a number: ");
                num = int.Parse(Console.ReadLine());
                if ((num % 2) != 0) throw new NotEvenException("Not an Even Number");
                else
                    Console.WriteLine("Its even number ");
            }
            catch (NotEvenException e) { Console.WriteLine(e.Message); }
            Console.ReadLine();//to hold the screen
        }
    }
}