using System;
namespace splitString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            Console.Write("Enter string : ");
            str1 = Console.ReadLine();
            string[] words = str1.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write("\" " + words[i] + "\" ");
            }
            Console.ReadLine();
        }
    }
}
