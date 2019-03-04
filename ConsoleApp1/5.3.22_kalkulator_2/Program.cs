using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._22
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0, b = 0;
            string operacija = "";
            Char odgovor = 'd';

            while (odgovor == 'd')
            {
                Console.WriteLine("Unesite prvi broj: ");
                a = float.Parse(Console.ReadLine());

                Console.WriteLine("Unesite drugi broj: ");
                b = float.Parse(Console.ReadLine());

                Console.WriteLine("Unesite računsku operaciju (+,-,*,/): ");
                operacija = Console.ReadLine();

                switch (operacija)
                {
                    case "+":
                        Console.WriteLine("Zbroj: {0}", a + b);
                        break;
                    case "-":
                        Console.WriteLine("Razlika: {0}", a - b);
                        break;
                    case "*":
                        Console.WriteLine("Umnožak: {0}", a * b);
                        break;
                    case "/":
                        Console.WriteLine("Kvocijent: {0}", a / b);
                        break;
                    default:
                        Console.WriteLine("Nepoznata računska operacija!");
                        break;
                }

                Console.WriteLine("Nastaviti računati? (D/N)");
                odgovor = Char.ToLower(Console.ReadKey().KeyChar);
                if (odgovor == 'n')
                {
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}