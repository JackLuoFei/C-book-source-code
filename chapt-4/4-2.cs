using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool grade_Flag = false ;
            int old_grade;
            string new_grade;
            Console.Write("请输入学生成绩：");
            old_grade = Convert.ToInt32(Console.ReadLine());
            /*
             //算法一
            if (old_grade < 0 || old_grade > 100)
            {
                Console.Write("成绩范围不对，请重新输入学生成绩：");
                old_grade = Convert.ToInt32(Console.ReadLine());
            }            
            switch (old_grade / 10)
            {
                case 10:
                case 9:
                    new_grade = "优秀"; break;
                case 8:
                    new_grade = "良好"; break;
                case 7:
                    new_grade = "中等"; break;
                case 6:
                    new_grade = "及格"; break;
                default :
                    new_grade = "不及格"; break;
            }
            Console.WriteLine("转换前成绩是{0},转换后成绩是{1}", old_grade, new_grade);
             */
            /*
            //算法二
            while(!grade_Flag)
            {
                if (old_grade < 0 || old_grade > 100)
            {
                Console.Write("成绩范围不对，请重新输入学生成绩：");
                old_grade = Convert.ToInt32(Console.ReadLine());
            }
            else
                grade_Flag = true ;
            }
            switch (old_grade / 10)
            {
                case 10:
                case 9:
                    new_grade = "优秀"; break;
                case 8:
                    new_grade = "良好"; break;
                case 7:
                    new_grade = "中等"; break;
                case 6:
                    new_grade = "及格"; break;
                default :
                    new_grade = "不及格"; break;
            }
            Console.WriteLine("转换前成绩是{0},转换后成绩是{1}", old_grade, new_grade);
          */
            while(old_grade < 0 || old_grade > 100)
            
           // if (old_grade < 0 || old_grade > 100)
            {
                Console.Write("成绩范围不对，请重新输入学生成绩：");
                old_grade = Convert.ToInt32(Console.ReadLine());             
            }
             
            switch (old_grade / 10)
            {
                case 10:
                case 9:
                    new_grade = "优秀"; break;
                case 8:
                    new_grade = "良好"; break;
                case 7:
                    new_grade = "中等"; break;
                case 6:
                    new_grade = "及格"; break;
                default:
                    new_grade = "不及格"; break;
            }
            Console.WriteLine("转换前成绩是{0},转换后成绩是{1}", old_grade, new_grade);
        }
    }
}
