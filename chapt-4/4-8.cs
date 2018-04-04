using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, count = 0;
            string stop; 
            double sum = 0;
            Console.WriteLine("请输入成绩,以-1结束输入：");
            do
            {
                    stop =Console.ReadLine();
                    if (stop == "stop")
                        break;
                    else 
                    {
                        x = Convert.ToInt32(stop);
                    }
                    if (x > 100 || x < 0)
                    {
                        Console.WriteLine("成绩范围不对，不在0~100之间，请重新输入：");
                        continue;
                    }
                    sum = sum + x;
                    count = count + 1;
            } while (true);
            Console.WriteLine("平均成绩={0}",sum/count);

        }
    }
}
