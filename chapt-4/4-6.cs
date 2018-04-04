using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_6
{
    class Program
    {
        static void Main(string[] args)
        {
		int i ,j;
		          
        for (i = 1; i < 10; i++)
        {
            for (j = 1; j <= i; j++)
                Console.Write("{0}*{1}={2}\t", i, j, i * j);
            Console.WriteLine();
        }
        for (i = 9; i > 0; i--)
        {
            for (j = 1; j <= i; j++)
                Console.Write("{0}*{1}={2}\t", i, j, i * j);
            Console.WriteLine();
        }
        for (i = 9; i > 0; i--)
        {
            for (j = 1; j <= i; j++)
                Console.Write("{0}*{1}={2}\t", i, j, i * j);
            Console.WriteLine();
        }

        for (i = 1; i < 10; i++)
        {
            for (j = 1; j <= i; j++)
                Console.Write("{0}*{1}={2}\t", i, j, i * j);
            Console.WriteLine();
        }
        }  	
    }
}
