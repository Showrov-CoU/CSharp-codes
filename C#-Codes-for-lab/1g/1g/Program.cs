//Write programs using conditional statements and loops:
// Test for vowels.

using System;
namespace vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Enter a character : ");
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine(ch + " is vowel");
                    break;
                default:
                    Console.Write(ch + " is not a vowel");
                    break;
            }
            Console.ReadKey();
        }
    }
}