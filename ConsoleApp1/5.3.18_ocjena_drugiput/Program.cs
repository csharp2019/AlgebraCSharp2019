using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._18
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesi ocjenu: ");
                int ocjena = int.Parse(Console.ReadLine());
                while (ocjena < 1 || ocjena > 5)
                {
                    Console.Write("Unesi ocjenu: ");
                    ocjena = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Tvoja ocjena je: " + ocjena);
            }
            catch (Exception m)
            {
                Console.WriteLine("GRESKA: " + m);
            }
            Console.Read();
        }
    }
}