using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._3_kw_ks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite snagu u KW (kilowatima):");
            double kw = double.Parse(Console.ReadLine());

            Console.WriteLine("Snaga izražena u  konjskim snagama je {0}.", KWtoKS(kw));
            Console.ReadKey();

        }



        static double KWtoKS(double kw)
        {
            return kw * 1.35;


        }
    }
}
