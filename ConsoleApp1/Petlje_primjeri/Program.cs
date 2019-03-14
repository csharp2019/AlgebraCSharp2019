using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petlje_primjeri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ispis svih brojeva 0,1,2... 99 
            Console.WriteLine("\n\nIspis svih brojeva 0,1,2... 99");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n\nIspis svih brojeva 16,18,20... 88");
            //Ispis svih brojeva 16,18,20... 88 
            for (int i = 16; i < 89; i+=2)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine("\n\nIspis svih brojeva 135,130,125... 55");
            //Ispis svih brojeva 135,130,125... 55 
            for (int i = 135; i > 54; i -= 5)
            {
                Console.Write("{0} ", i);
            }
            //Ispis svih brojeva 0,1,2... 99 OSIM BROJA 80
            Console.WriteLine("\n\nIspis svih brojeva 0,1,2... 99 -> OSIM BROJA 80");
            for (int i = 0; i < 100; i++)
            {
                if (i == 80)
                {
                    continue;
                }
                Console.Write("{0} ", i);
            }
            //Ispis svih brojeva 0,1,2... 99 PRESKOČI VEĆE OD 80
            Console.WriteLine("\n\nIspis svih brojeva 0,1,2... 99 -> break na 80 ");
            for (int i = 0; i < 100; i++)
            {
                if (i == 80)
                {
                    break;
                }
                Console.Write("{0} ", i);
            }
            //Ispis svih brojeva 0,1,2... 9999 Koji su djeljivi sa 17
            Console.WriteLine("\n\nIspis svih brojeva 0,1,2... 9999 Koji su djeljivi sa 17 ");
            for (int i = 0; i < 10000; i++)
            {
                if (i % 17 == 0 && i % 13 == 0)
                {
                   Console.Write("{0} ", i); 
                }
                
            }

            //Ispis svih brojeva 0,1,2... 99 
            Console.WriteLine("\n\n####   TABLICA MNOŽENJA   ####");
            Console.WriteLine("\n\n");
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}\t", (i*j).ToString());
                }
                Console.WriteLine();

            }

            //Suma prvih 100
            Console.WriteLine("\n\nSuma prvih 100");
            int suma = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", suma+=i);
            }



            Console.ReadLine();
        }
    }
}
