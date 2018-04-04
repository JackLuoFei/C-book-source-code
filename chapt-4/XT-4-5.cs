using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XT_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int end_count = 1;
            for(int day=10;day>1;day--)
            {
                end_count = (end_count + 1) * 2;
                sum = end_count;
            }
            Console.WriteLine("猴子第一天的桃子总数为：{0}",sum);
        }
    }
}
