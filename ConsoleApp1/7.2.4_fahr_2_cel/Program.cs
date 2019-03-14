using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._4_fahr_2_cel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite temperaturu u Fahrenheit:");
            double fahrenheit = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}F = {1}C", fahrenheit, FuC(fahrenheit));
            Console.ReadKey();
        }
        static double FuC(double fahrenheit)
        {
            return (double)5 / 9 * (fahrenheit - 32);
        }
    }
}
