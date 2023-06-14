//Write a program for above class hierarchy for the Employee where the base class is Employee and derived class and Programmer and Manager. 
//Here make display function virtual which is common for all and which will display information of Programmer and Manager interactively.


using System;
namespace HeirarchicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer objProgrammer;
            Manager objManager;
            Console.Write("Whose details you want to use to see \n 1.Programmer \n 2.Manager,press 0 for exit\n");
            int choice = int.Parse(Console.ReadLine());
            while (choice != 0)
            {
                if (choice == 1)
                {
                    objProgrammer = new Programmer();
                    objProgrammer.display();
                }
                else if (choice == 2)
                {
                    objManager = new Manager();
                    objManager.display();
                }
                else
                {
                    Console.WriteLine("Wrong choice entered");
                }
                Console.Write("Whose details you want to use to see \n 1.Programmer \n 2.Manager,press 0 for exit\n");
                choice = int.Parse(Console.ReadLine());
                
            }
            Console.ReadLine();//to hold the screen
        }
    }
}