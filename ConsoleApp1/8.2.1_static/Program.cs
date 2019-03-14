using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._1_static
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prvi broj: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Zbroj: {0}", Static.Zbroj(a, b));

            Console.Write("Unesite broj za kubiranje: ");
            double broj = double.Parse(Console.ReadLine());
            Console.WriteLine("Kub: {0}", Static.Kub(broj));


            Console.Write("Unesite x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Unesite x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Unesite y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Unesite y2: ");
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Udaljensot točaka: " + Static.Udaljenost(x1, x2, y1, y2));

            Console.Write("Unesite Celzijuse: ");
            double stupnjevaCelzijusa = double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit: {0}", Static.Fahrenheit(stupnjevaCelzijusa));

            Console.ReadKey();
        }
    }
}
