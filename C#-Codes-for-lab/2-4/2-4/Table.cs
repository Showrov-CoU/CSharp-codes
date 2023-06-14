using System;
namespace SingleInheritance
{
class Table:Furniture
{
int height, surface_area;
public void getdata()
{
base.getdata();
Console.Write("Enter height: ");
height = int.Parse(Console.ReadLine());
Console.Write("Enter surface area: ");
surface_area = int.Parse(Console.ReadLine());
}
public void showdata()
{
    base.showdata();
    Console.WriteLine("Height : " + height);
    Console.WriteLine("Surface Area : " + surface_area);
}
}
}