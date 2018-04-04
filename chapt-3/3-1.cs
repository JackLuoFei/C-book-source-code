using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1
{
    class Circle
    {
        private double x, y, r;
        public void SetPoint(double a,double b,double c)
        {
            x = a;
            y = b;
            r = c;
        }
        public void Print()
        {
            Console.WriteLine("[" + x + "," + y + "]," + "Radius=" + r);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle p = new Circle();
            p.SetPoint(30, 50, 10);
            Console.WriteLine("Circle P:");
            p.Print();
        }
    }
}
