using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._2._1_timespan
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum1 = new DateTime(2019, 2, 22);
            DateTime datum2 = new DateTime(2019, 3, 28);
            TimeSpan interval1 = datum2 - datum1;

            Console.WriteLine("Intervali izmadju {0} i {1} je {2}", datum1,datum2,interval1);
            Console.WriteLine("U satima..." + interval1.Hours);
            Console.WriteLine("U minutama..." + interval1.Hours);
            Console.WriteLine("U danima..." + interval1.Days);
            Console.WriteLine("U satima ukupno..." + interval1.TotalHours);
            Console.WriteLine("U minutama ukupno..." + interval1.TotalMinutes);

            Console.ReadKey();
        }
    }
}
