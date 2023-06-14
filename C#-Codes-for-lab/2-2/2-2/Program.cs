//Write a program to declare class ‘Distance’ have data members dist1,dist2 ,dist3. 
//Initialize the two data members using constructor and store their addition in third data member using function and display addition.

using System;
namespace distanceclass
{
    class Distance
    {
        int dist1, dist2, dist3;
        public Distance(int dist1, int dist2)
        {
            this.dist1 = dist1;
            this.dist2 = dist2;
        }
        public void addition()
        {
            dist3 = dist1 + dist2;
        }
        public void display()
        {
            Console.WriteLine("Distance1:" + dist1);
            Console.WriteLine("Distance1:" + dist2);
            Console.WriteLine("Distance1:" + dist3);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Distance objDistance = new Distance(10, 20);//CONSTRUCTOR
            objDistance.addition();
            objDistance.display();
            Console.ReadLine();//to hold the screen
        }
    }
}