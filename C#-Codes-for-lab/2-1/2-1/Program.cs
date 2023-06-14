//Write a program to declare a class ‘staff’ having data members as name and post.accept this data 5for 5 staffs and display names of staff who are HOD.

using System;
namespace staff
{
    class staff
    {
        string name, post;
        public void getdata()
        {
            Console.Write("Enter name and post:");
            name = Console.ReadLine();
            post = Console.ReadLine();
        }
        public void display()
        {
            Console.WriteLine(name + "\t\t" + post);
        }
        public string getPost()
        {
            return post;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            staff[] objStaff = new staff[5];
            int i;
            for (i = 0; i < 2; i++)
            {
                objStaff[i] = new staff();
                objStaff[i].getdata();
            }
            Console.WriteLine("Name \t\t Post");
            for (i = 0; i < 2; i++)
            {
                if (objStaff[i].getPost() == "HOD")
                    objStaff[i].display();
            }
            Console.ReadLine();//to hold the screen
        }
    }
}