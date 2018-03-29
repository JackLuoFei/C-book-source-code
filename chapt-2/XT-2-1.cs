using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XT_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("三个任意小数的加法\n");
            Console.WriteLine("请输入第1个小数：");
            Single a =Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("请输入第2个小数：");
            Single b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("请输入第3个小数：");
            Single c = Convert.ToSingle(Console.ReadLine());
            Single d = a + b + c;
            Console.WriteLine("{0}",d);
            Single e = d * 100;
            if(e%10>4) e=((e-(e%10))+10);
            else e=e-(e%10);
            Single f=e/100;
            Console.WriteLine("四舍五入保留两位小数后的和为：{0}",f);

        }
    }
}
