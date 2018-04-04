using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5]{11,22,33,44,55};
            int max = 0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            Console.WriteLine("最大数是：{0}", max);
        }
    }
}
