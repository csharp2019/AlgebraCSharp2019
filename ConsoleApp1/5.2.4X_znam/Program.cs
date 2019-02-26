using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._4X_znam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi broj:");
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                a = -a;
            }
            if (a < 10)
            {
                Console.Write("Unešeni broj je jednoznamenkasti!");
            }
            else if (a < 100)
            {
                Console.Write("Unešeni broj je dvoznamenkasti!");
            }
            else if (a < 1000)
            {
                Console.Write("Unešeni broj je troznamenkasti!");
            }
            else
            {
                Console.Write("Unešeni broj je višeznamenkasti!");
            }
            Console.ReadKey();
        }
    }
}
