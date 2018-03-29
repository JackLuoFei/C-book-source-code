using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XT_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, e, f, h, i, j, temp1, max = 0;
            Console.WriteLine("输入六个数，比较大小后输出最大的数\n\n");
            Console.WriteLine("请输入6个数分别以空格分隔，输入完毕以回车键结束\n");
            string s = Console.ReadLine();
            string[] sSplit = s.Split(' ');
            a = Convert.ToInt32(sSplit[0]);
            b = Convert.ToInt32(sSplit[1]);
            c = Convert.ToInt32(sSplit[2]);
            d = Convert.ToInt32(sSplit[3]);
            e = Convert.ToInt32(sSplit[4]);
            f = Convert.ToInt32(sSplit[5]);
            //算法一
            
            if (a > b && a > c && a > d && a > e && a > f)
                max = a;
            if (b > a && b > c && b > d && b > e && b > f)
                max = b;
            if (c > a && c > b && c > d && c > e && c > f)
                max = c;
            if (d > a && d > b && d > c && d > e && d > f)
                max = d;
            if (e > a && e > b && e > c && e > d && e > f)
                max = e;
            if (f > a && f > b && f > c && f > d && f > e)
                max = f;
              
            //算法二
            /*
            if (a > b)  h= a;
            else        h = b;
            if (c > d)  i= c;
            else        i= d;
            if (e > f)  j = e;
            else        j= f;
            if (h > i)  temp1 = h;
            else        temp1 = i;
            if (temp1 > j)  max = temp1;
            else            max = j;
            */
            //算法三
            /*
            if (a < b)
                a = b;
            if (a < c)
                a = c;
            if (a < d)
                a = d;
            if (a < e)
                a = e;
            if (a < f)
                a = f;
            max = a;
            */
            Console.WriteLine("你输入的数是:\n {0}，{1}，{2}，{3}，{4}，{5}\n", a, b, c, d, e, f);
            Console.WriteLine("最大的数是:{0}", max);

            //算法4


        }
    }
}
