using System;
namespace SalaryConstructure
{
    class Salary
    {
        int basic, ta, da, hra;
        public Salary()
        {
            da = 9000;
            hra = 6000;
        }
        public void getdata()
        {
            Console.Write("Enter basic salary : ");
            basic = int.Parse(Console.ReadLine());
            Console.Write("Enter travelling allowance : ");
            ta = int.Parse(Console.ReadLine());
        }
        public void showdata()
        {
            Console.WriteLine("Basic salary : " + basic);
            Console.WriteLine("Dearness allowence : " + da);
            Console.WriteLine("Housing rent allowence : " + hra);
            Console.WriteLine("Travelling allowence : " + ta);
            Console.WriteLine("Gross Salary : " + (basic + da + hra + ta));
        }
    }
}