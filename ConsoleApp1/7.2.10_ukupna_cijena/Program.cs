using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._10_ukupna_cijena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite ukupnu cijenu");
            float uk = float.Parse(Console.ReadLine());
            Console.WriteLine("Ulazna cijena - marza je {0}", ulazna(uk));
            Console.ReadKey();
        }
        static double ulazna(float uk)
        {
            int ulazna = 0;
            double marza = 0;
            double porez = 0;
            double pdv = 0.25;
            Console.WriteLine("odaberite'1 za <100', '2 za 100-250', '3 za 250-500', '4 za 500-1000', '5 za >1000'");
            ulazna = int.Parse(Console.ReadLine());
            switch (ulazna)
            {
                case 1:
                    marza = 5.5;
                    porez = 0.02;
                    break;

                case 2:
                    marza = 9.5;
                    porez = 0.03;
                    break;

                case 3:
                    marza = 15;
                    porez = 0.04;
                    break;

                case 4:
                    marza = 25;
                    porez = 0.05;
                    break;

                case 5:
                    marza = 50;
                    porez = 0.1;
                    break;
            }
            double ul;
            ul = uk - marza;
            Console.WriteLine("porez na ulaznu cijenu je {1}%, a pdv na ulaznu cijenu je {2}%", ul, porez * 100, pdv * 100);
            return ul;
        }
    }
}
