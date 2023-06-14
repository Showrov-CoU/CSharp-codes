using System;
namespace multilevelinheritance
{
class Test:student
{
int marks1, marks2;
public Test(int roll_no, string name, int marks1, int marks2)
: base(roll_no, name)
{
this.marks1 = marks1;
this.marks2 = marks2;
}
public int getMarks1()
{
    return marks1;
}
public int getMarks2()
{
    return marks2;
}
public void display()
{
    base.display();
    Console.WriteLine("Marks1: " + marks1);
    Console.WriteLine("Marks2: " + marks2);
}
}
}