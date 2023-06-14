using System;
namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Salary s = new Salary("Zahid", 35000);
            s.da = 20000;
            s.ta = 30000;
            s.dispSal();
            Console.ReadLine();//to hold the screen
        }
    }
}