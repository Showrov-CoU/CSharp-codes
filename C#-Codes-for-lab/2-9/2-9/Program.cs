using System;
namespace TrafficDelegateExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficSignal ts = new TrafficSignal();
            ts.IdentifySignal();
            ts.display();
            Console.ReadLine();//to hold the screen
        }
    }
}