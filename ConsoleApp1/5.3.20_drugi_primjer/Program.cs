using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zz_5._3._20_par_nepar
{
    class Program
    {
        static void Main(string[] args)
        {
            int par = 0;
            int nepar = 0;
            int broj = -1;

            try
            {
                while (broj != 0)
                {
                    Console.WriteLine("Unesite prirodan broj: ");
                    broj = int.Parse(Console.ReadLine());

                    if (broj < 0)
                    {
                        throw new NegativeNumberException("Broj ne smije biti negativan");
                    }

                    if (broj != 0)
                    {
                        if (broj % 2 == 0)
                        {
                            par++;
                        }
                        else
                        {
                            nepar++;
                        }
                    }
                }
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("GREŠKA: Dozvoljeni su samo prirodni brojevi." + ex.Message);
            }
            catch (FormatException fex)
            {
                Console.WriteLine("GREŠKA: Nije unešen numerički znak." + fex.Message);
            }
            finally
            {
                Console.WriteLine("Parni brojevi: " + par.ToString());
                Console.WriteLine("Neparni brojevi: " + nepar.ToString());
                Console.ReadKey();
            }
        }
        public class NegativeNumberException : Exception
        {
            public NegativeNumberException(String poruka)
            {
                Console.WriteLine(poruka);
            }
        }
    }
}