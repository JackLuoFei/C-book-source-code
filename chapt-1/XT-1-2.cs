using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("两个数的加、减、乘、除法\n\n");
            Console.WriteLine("请输入第一个数，以回车键结束");
            string s = Console.ReadLine();
            decimal a = Convert.ToDecimal(s);
            Console.WriteLine("请输入第二个数，以回车键结束");
            s = Console.ReadLine();
            decimal b = Convert.ToDecimal(s);
            decimal c = a + b;
            Console.WriteLine("\n {0} + {1} 等于 {2}", a, b, c);
            decimal d = a - b;
            Console.WriteLine("\n {0} - {1} 等于 {2}", a, b, d);
            decimal e = a * b;
            Console.WriteLine("\n {0} * {1} 等于 {2}", a, b, e);
            decimal f = a / b;
            Console.WriteLine("\n {0} / {1} 等于 {2}\n", a, b, f);
        }
    }
}
