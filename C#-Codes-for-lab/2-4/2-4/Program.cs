using System;
namespace SingleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Table t1 = new Table();
            t1.getdata();
            t1.showdata();
            Console.ReadLine();//to hold the screen
        }
    }
}