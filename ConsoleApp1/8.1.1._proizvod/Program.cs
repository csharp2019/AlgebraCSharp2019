using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._1._proizvod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite naziv prozivoda: ");
            Proizvod proizvod = new Proizvod(Console.ReadLine());

            Console.Write("Unesite cijenu proizvoda: ");
            proizvod.Cijena = double.Parse(Console.ReadLine());
            Console.Write("Unesite maržu proizvoda: ");
            proizvod.Marza = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite porez na prozivod: ");
            proizvod.Porez = double.Parse(Console.ReadLine());

            Console.WriteLine("Maloprodajna cijena proizvoda {0} je {1}.",
                proizvod.Naziv,
                proizvod.MPC());

            Console.ReadKey();

        }
    }
}
