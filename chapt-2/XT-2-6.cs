using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XT_2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入总共的秒数：");
            string a = Console.ReadLine();
            uint b = Convert.ToUInt32(a);
            uint h, m, s;
            h = b / 3600;
            m = b / 60%60;
            s = b % 60;
            Console.WriteLine("{0}时{1}分{2}秒",h,m,s);

        }
    }
}
