using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_5._3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int koliko = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 7 == 0 && i % 3 != 0)
                {
                    koliko++;
                }
            }
            Console.WriteLine("U intervalu od 1 do 1000 ima {0} brojeva\ndjeljivih sa 7 i nedjeljivih sa 3!", koliko);
            Console.ReadKey();
        }
    }
}