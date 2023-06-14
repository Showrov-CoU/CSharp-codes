//Write a console application that obtains four int values from the user and displays the product.
using System;
namespace product
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4, prod;
            Console.Write("Enter number 1: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 4: ");
            num4 = Convert.ToInt32(Console.ReadLine());
            prod = num1 * num2 * num3 * num4;
            Console.WriteLine(num1 + "*" + num2 + "*" + num3 + "*" + num4 + "=" + prod);
            Console.ReadLine();
        }
    }
}

