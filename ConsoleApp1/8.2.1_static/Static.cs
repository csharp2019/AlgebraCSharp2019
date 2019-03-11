using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._1_static
{
    public class Static

    {
        private Static() { }

        public static double Zbroj(double a, double b)
        {
            return a + b;
        }
        public static double Kub(double broj)
        {
            return broj * broj * broj;
        }
        public static double Udaljenost(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));
        }
        public static double Fahrenheit(double stupnjevaCelzijusa)
        {
            return ((double)9 / 5) * stupnjevaCelzijusa + 32;
        }
    }
}