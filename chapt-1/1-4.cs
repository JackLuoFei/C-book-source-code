using System;


namespace _1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string s = System.Console.ReadLine();
            decimal a = Convert.ToDecimal(s);
            s = Console.ReadLine();
            decimal b = Convert.ToDecimal(s);
            decimal c = a + b;
            
            Console.WriteLine("{0}+{1}={2}",a,b,c);
            */
            
            Console.WriteLine("两个数的加法\n\n");
            Console.WriteLine("请输入第一个数，以回车键结束");
            string s = Console.ReadLine();
            decimal a = Convert.ToDecimal(s);
            Console.WriteLine("请输入第二个数，以回车键结束");
            s = Console.ReadLine();
            decimal b = Convert.ToDecimal(s);
            decimal c = a + b;
            Console.WriteLine("\n {0} + {1} 等于 {2}",a,b,c);
            
        }
    }
}
