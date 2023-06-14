using System;
namespace SalaryConstructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Salary s = new Salary();
            s.getdata();
            s.showdata();
            Console.ReadLine();//to hold the screen
        }
    }
}