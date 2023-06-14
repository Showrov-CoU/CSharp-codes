using System;
namespace MultipleInheritance
{
    class Salary : Employee, Gross
    {
        int hra;
        public Salary(string name, int hra)
            : base(name)
        { this.hra = hra; }
        public int ta
        {
            get { return S_ta; }
            set { S_ta = value; }
        }
        private int S_ta;
        public int da
        {
            get { return S_da; }
            set { S_da = value; }
        }
        private int S_da;
        public int GrossSal()
        {
            int gSal;
            gSal = hra + ta + da + BasicSal(15000);
            return gSal;
        }
        public void dispSal()
        {
            base.ShowData();
            Console.WriteLine("Gross Sal : " + GrossSal());
        }
    }
}