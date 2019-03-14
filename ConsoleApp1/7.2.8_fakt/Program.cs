using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._8_fakt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite prirodan broj: ");
            try
            {
                int broj = int.Parse(Console.ReadLine());
                if (broj <= 0)
                {
                    throw new PrirodanBrojException("UNESITE PRIRODAN BROJ!");
                }

                Console.WriteLine("{0}! = {1}", broj, Faktorijel(broj));
            }
            catch (PrirodanBrojException pex)
            {
                Console.WriteLine("Greška. Poruka: " + pex.ToString());
            }
            catch (FormatException fex)
            {
                Console.WriteLine("Greška. Poruka: " + fex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Greška. Poruka: " + ex.ToString());
            }
            finally
            {
                Console.ReadLine();
            }
        }

        static int Faktorijel(int broj)
        {
            if (broj == 1)
            {
                return broj;
            }
            else
            {
                return broj * Faktorijel(broj - 1);
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
}

