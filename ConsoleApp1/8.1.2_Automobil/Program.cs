using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2_Automobil
{
    class Program
    {
        static void Main(string[] args)
        {
            Automobil automobil = new Automobil();

            Console.Write("Unesite marku automobila: ");
            automobil.MarkaAutomobila = Console.ReadLine();
            Console.Write("Unesite broj konjskih snaga: ");
            automobil.KS = double.Parse(Console.ReadLine());
            Console.Write("Unesite osnovnu cijenu automobila: ");
            automobil.OsnovnaCijena = double.Parse(Console.ReadLine());

            Console.WriteLine("Iznos poreza: {0}\nUkupna cijena: {1}", automobil.IznosPoreza(), automobil.UkupnaCijena());
            Console.ReadKey();

        }
    }
}
