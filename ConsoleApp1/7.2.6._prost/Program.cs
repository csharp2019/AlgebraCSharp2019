using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._6._prost
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = -1;
            Console.WriteLine("Unesite prirodan broj: ");
            try
            {
                x = int.Parse(Console.ReadLine());
            }
            catch (FormatException fex)
            {
                Console.WriteLine(fex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            if (CheckProsti(x))
            {
                Console.WriteLine("Broj {0} je prost.", x);
            }
            else
            {
                Console.WriteLine("Broj {0} nije prost.", x);
            }

            Console.ReadKey();
        }

        static bool CheckProsti(int x)
        {
            bool prost = true;

            for (int i = 2; i < x; i++)
            {
                if (x % i == 0)
                {
                    prost = false;
                    break;
                }
            }

            return prost;
        }
    }
}
