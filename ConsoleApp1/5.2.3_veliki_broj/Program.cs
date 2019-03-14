using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._3_veliki_broj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upišite broj: ");
            int broj = int.Parse(Console.ReadLine());

            if (broj >= 1000)
            {
                Console.WriteLine("Broje je velik!");
            }
            else
            {
                Console.WriteLine("Broj NIJE velik!");
            }
            Console.ReadKey();
        }
    }
}
