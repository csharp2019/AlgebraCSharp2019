using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_18_unos_cijene
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int a = 0;
                bool unosOK = false;


                while (!unosOK)
                {
                    Console.WriteLine("Unesite vašu ocjenu [1,5]: ");
                    a = int.Parse(Console.ReadLine());

                    if (a == 1 || a == 2 || a == 3 || a == 4 || a == 5)
                    {
                        unosOK = true;
                    }

                    else
                    {
                        Console.WriteLine("Ocjena krivo unešena!");
                    }
                }

                Console.WriteLine("\n -hvala najljepša...");
            }

            catch (FormatException fex)
            {
                Console.WriteLine("Ponovno pokrenite program i unesite cijeli prirodni broj! \n\n\n" + fex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}