using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._1_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum1 = new DateTime(2019, 2, 22);
            DateTime datum2 = new DateTime(2019, 3, 28);
            DateTime datum3 = new DateTime(2020, 2, 22);  // prijestupna

            if (datum1 < datum2)
            {
                Console.WriteLine(datum1.ToString() + " je manji od datuma  " + datum2.ToString());
            }
            else
            {

                Console.WriteLine(datum1.ToString() + " je veći od datuma  " + datum2.ToString());

            }
            Console.WriteLine("Trenutno je:" + DateTime.Now);
            Console.WriteLine("Trenutno je:" + DateTime.Today);
            // (Uvijet)?true:false
            Console.WriteLine((DateTime.IsLeapYear(2020)) ? "Ovo je prijstupna godina " : "Ovo nije prijstupna godina ");

            Console.WriteLine("Danas je:" + DateTime.Today.DayOfWeek);

            Console.WriteLine(datum1 + " datum + 7 dana :" + datum1.AddDays(7));
            Console.WriteLine(datum3 + " datum + 7 dana :" + datum3.AddDays(7));
            Console.ReadKey();
        }
    }
}
