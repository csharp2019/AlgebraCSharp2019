using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak_5._3._14_neparni_brojevi
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0;
            float b = 0;

            try
            {
                Console.Write("unesite 1. broj: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("unesite 2. broj: ");
                b = int.Parse(Console.ReadLine());

                if (a > b)
                {
                    throw new Exception_neispravan_niz("neispravan niz");
                }

                {
                    Console.WriteLine("\n" +
                        "neparni brojevi u rasponu od {0} do {1} su: ", a, b);

                    for (float i = a; i <= b; i++)

                        if (i % 2 != 0)

                        {
                            Console.Write("\n{0}; ", i);
                        }
                }


            }

            catch (Exception_neispravan_niz exnn)

            {
                Console.WriteLine("\nUneseni niz nije OK, pocetak intervala je veći od kraja "+exnn.ToString());
            }

            catch (FormatException fex)
            {
                Console.WriteLine("GREŠKA, Nije unešen numerički znak:"
                    + fex.Message
                    + "\n"
                    + fex.ToString());
            }





            finally
            {
                Console.WriteLine("\n\nza kraj stisni nešto");
                Console.ReadLine();

            }

        }





        public class Exception_neispravan_niz : Exception
        {
            public Exception_neispravan_niz()
            {
            }

            public Exception_neispravan_niz(string message) : base(message)
            {
            }

            public Exception_neispravan_niz(string message, Exception inner) : base(message, inner)
            {

            }

        }
    }
}