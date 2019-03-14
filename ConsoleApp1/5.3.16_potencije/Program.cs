using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potencije_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Potencije broja 2 manje od 1000:");

            for (int i = 1; i < 1000; i *= 2)
            {
                try
                {
                    Console.WriteLine("{0}", i.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("" + ex.ToString());
                }
            }
            Console.ReadKey();
        }
    }
}