//Write a program using function overloading to swap two integer numbers and swap two float numbers.
using System;
namespace swap
{
    class Overloading
    {
        public void swap(ref int n, ref int m)
        {
            int t;
            t = n;
            n = m;
            m = t;
        }
        public void swap(ref float f1, ref float f2)
        {
            float f;
            f = f1;
            f1 = f2;
            f2 = f;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Overloading objOverloading = new Overloading();
            int n = 10, m = 20;
            objOverloading.swap(ref n, ref m);
            Console.WriteLine("N=" + n + "\tM=" + m);
            float f1 = 10.5f, f2 = 20.6f;
            objOverloading.swap(ref f1, ref f2);
            Console.WriteLine("F1=" + f1 + "\tF2=" + f2);
            Console.ReadLine();//to hold the screen
        }
    }
}