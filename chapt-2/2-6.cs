using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 2-6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input one integer 1000<n<9999");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Before inverse the number is:{0}", n);
            char c1 = Convert.ToChar(n % 10+'0');
            char c2 = Convert.ToChar(n / 10 % 10 + '0');
            char c3 = Convert.ToChar(n / 100 % 10 + '0');
            char c4 = Convert.ToChar(n / 1000 + '0');
            Console.WriteLine("After inverse the number is:{0}{1}{2}{3}", c1, c2, c3, c4);



        }
    }
}
