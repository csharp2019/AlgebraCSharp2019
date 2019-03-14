using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._12.suma_i_prosjek
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5.3.12 Suma i prosjek
            // Napišite program koji traži unos 5 prirodnih brojeva, a zatim ispisuje njihovu sumu i prosjek
            int broj;
            int suma = 0;
            double prosjek;

            try
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Unesite {0}. prirodni broj: ", i.ToString());
                    broj = int.Parse(Console.ReadLine());
                    if (broj <= 0)
                    {
                        throw new PrirodanBrojException("UNESITE PRIRODAN BROJ!");
                    }
                    suma += broj;
                }
                prosjek = (double)suma / 5;
                Console.Write("Suma = {0} \nProsjek = {1}", suma, prosjek);
            }
            catch (PrirodanBrojException ex)
            {
                Console.WriteLine("Greška. Poruka: " + ex.ToString());
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Greška. Poruka: " + ex.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Greška. Poruka: " + e.ToString());
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}

public class PrirodanBrojException : Exception
{
    public PrirodanBrojException()
    {
    }

    public PrirodanBrojException(string message) : base(message)
    {
    }

    public PrirodanBrojException(string message, Exception innerException) : base(message, innerException)
    {
    }
}