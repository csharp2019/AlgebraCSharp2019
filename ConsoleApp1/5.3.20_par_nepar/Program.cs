using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatak_5._3._20
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int parni = 0;
            int neparni = 0;
            try
            {
                Console.WriteLine("Unosite brojeve sve dok ne unesete 0, program će ispisati koliko ste unjeli parnih, a koliko neparnih brojeva");
                while (a != 0)
                {
                    a = int.Parse(Console.ReadLine());
                    if (a % 2 == 0)
                    {
                        if (a != 0)
                        {
                            parni++;
                        }
                    }
                    if (a % 2 == 1)
                    {
                        neparni++;
                    }
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Nije unešen broj " + ex.ToString());
            }
            finally
            {
                Console.WriteLine("Na kraju je unešeno {0} parnih i {1} neparnih brojeva", parni, neparni);
                Console.ReadKey();
            }
        }
    }
}