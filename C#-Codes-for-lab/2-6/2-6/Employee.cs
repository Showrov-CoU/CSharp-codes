using System;
namespace MultipleInheritance
{
    class Employee
    {
        string name;
        public Employee(string name)
        { this.name = name; }
        public int BasicSal(int basicSal)
        { return basicSal; }
        public void ShowData()
        {
            Console.WriteLine("Name : " + name);
        }
    }
}