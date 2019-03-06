using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._2._jednakokracan_trokut
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("--PRAVOKUTNI TROKUT--");
                Console.ResetColor();

                Console.WriteLine("\nUnesite duljinu jedne od kateta Vašeg trokuta: ");
                double k1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Unesite površinu Vašeg trokuta: ");
                double P = double.Parse(Console.ReadLine());

                if (k1 == 0 || P == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nUnešeni parametri ne odgovaraju geometrijskom liku!");
                    Console.ResetColor();

                }
                else
                {
                    Console.WriteLine("Duljina druge katete vašeg trokuta je: {0}", Kateta(k1, P));
                }
            }

            catch (FormatException fex)
            {
                Console.WriteLine("KRIVI FORMAT..." + fex.ToString());
            }




            Console.ReadLine();

        }

        static double Kateta(double k1, double P)
        {
            return 2 * P / k1;
        }
    }
}
