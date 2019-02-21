using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //comment
            //comment 2
            //jhjxchjx
            /*
             * Ovo je blok komentar
             * */
            Probna p = new Probna();
            Console.WriteLine(p.A);
            Console.WriteLine("Rješenje je zbroj 20 + 10 = "+ p.Add(p.A,p.b));
            Console.ReadKey();
        }
    }
}
