/*Write an application that receives the following information from a set of students: 
 Student Id: 
 Student Name: 
 Course Name: 
 Session: 
 The application should also display the information of all the students once the data is 
Entered. Implement this using an Array of Structures. */

using System;
namespace ArrayOfStructs
{
    class Program
    {
        struct Student
        {
            public string studid, name, cname,session;
        }
        static void Main(string[] args)
        {
            Student[] s = new Student[5];
            int i;
            for (i = 0; i < 2; i++)
            {
                Console.Write("Enter Student Id:");
                s[i].studid = Console.ReadLine();
                Console.Write("Enter Student name : ");
                s[i].name = Console.ReadLine();
                Console.Write("Enter Course name : ");
                s[i].cname = Console.ReadLine();
                Console.Write("Enter session : ");
                s[i].session = Console.ReadLine();
            }
            Console.WriteLine("\n\nStudent's List\n");
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("\nStudent ID : " + s[i].studid);
                Console.WriteLine("\nStudent name : " + s[i].name);
                Console.WriteLine("\nCourse name : " + s[i].cname);
                Console.WriteLine("\nSession : " + s[i].session);
            }

            Console.ReadLine();//to hold the screen
        }
    }
}