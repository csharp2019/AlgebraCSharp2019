using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._5_prosti_faktor
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = int.Parse(Console.ReadLine());
            List<int> prosti = new List<int>();

            int fak = 2;
            while (fak<=broj)
            {
                if (broj % fak == 0)
                {
                    prosti.Add(fak);
                    broj = broj / fak;
                }
                else
                {
                    fak++;
                }
            }
            foreach (int item in prosti)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}
