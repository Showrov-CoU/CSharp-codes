using System;
namespace SingleInheritance
{
    class Furniture
    {
        string material;
        float price;
        public void getdata()
        {
            Console.Write("Enter material : ");
            material = Console.ReadLine();
            Console.Write("Enter price : ");
            price = float.Parse(Console.ReadLine());
        }
        public void showdata()
        {
            Console.WriteLine("Material : " + material);
            Console.WriteLine("Price : " + price);
        }
    }
}