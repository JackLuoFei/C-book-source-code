using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 2-3
{
    public enum TimeofDay
    {
        Morning,
        Afternoon,
        Evening
    }
    class Program
    {
        static void WriteGreeting(TimeofDay timeofday)
        {
            switch (timeofday)
            {
                case TimeofDay.Morning:
                    Console.WriteLine("GoodMorning");
                    break;
                case TimeofDay.Afternoon:
                    Console.WriteLine("GoodAfternoon");
                    break;
                case TimeofDay.Evening:
                    Console.WriteLine("GoodEvening");
                    break;
            }
        }
        static void Main(string[] args)
        {
            WriteGreeting(TimeofDay.Morning);
            //WriteGreeting(TimeofDay.Afternoon);
            WriteGreeting(TimeofDay.Evening);
        }
    }
}
