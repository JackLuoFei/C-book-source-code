using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            int temp_max = 0;
            Console.WriteLine("输入5个数分别以回车键结束：");
            for (int i = 0; i < array1.Length;i++ )
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            //冒泡排序算法
            for (int i = 1; i < array1.Length;i++ )
                for (int j = 1; j <=array1.Length-i; j++)
                {
                    if (array1[j] > array1[j-1])
                    {
                        temp_max = array1[j];
                        array1[j] = array1[j-1];
                        array1[j-1] = temp_max;
                    }
                }

                foreach (int i in array1)
                {
                    Console.WriteLine(i);
                }
            Console.WriteLine("最大的数是{0}",array1[4]);
        }
    }
}
