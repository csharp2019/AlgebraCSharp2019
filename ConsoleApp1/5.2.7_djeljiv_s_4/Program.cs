using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._7_djeljiv_s_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upišite broj: ");
            int broj = 0;
            try
            {
                broj = int.Parse(Console.ReadLine());
                if (broj % 4 == 0 && broj >= 100)
                {
                    Console.WriteLine("Broje je djeljiv sa 4 i nije manji od 100");
                }
                else
                {
                    Console.WriteLine("Broj NIJE dobar! Broje nije djeljiv sa 4 i/ili je manji od 100");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Provjeri je li unešen broj? "+e.ToString());
            }


            Console.ReadKey();
        }
    }

}
