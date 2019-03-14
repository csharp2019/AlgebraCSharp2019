using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._1_primjer
{
    class Program
    {
        static void Main(string[] args)
        {

            // deklaracija
            int?[] niz = new int?[3];

            // init
            niz[0] = 55;
            // niz[2] = null;
            niz[2] = 77;
            niz[1] = 22;
            try {
                niz[3] = 99;
                for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] == null)
                {
                    throw new Exception("Niz sadrži ne inicijaliziranu vrijednost na indexu "+i);
                }
                Console.WriteLine((i+1)+": "+niz[i]+ niz[2]);
            }
            }
            catch(IndexOutOfRangeException ioorex)
            {
                Console.WriteLine("Pokušali ste dohvatiti nepostojeći član niza "
                    +ioorex.ToString());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();

        }
    }
}
