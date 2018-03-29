using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XT_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("三个整数求平均值\n");
            Console.WriteLine("请输入第1个数：");
            decimal a = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("请输入第2个数：");
            decimal b = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("请输入第3个数：");
            decimal c = Convert.ToDecimal(Console.ReadLine());
            decimal d = (a + b + c)/3;
            Console.WriteLine("{0}", d);
         }
    }
}
