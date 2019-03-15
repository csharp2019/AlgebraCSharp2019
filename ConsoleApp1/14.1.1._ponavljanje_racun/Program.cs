using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._1._1._ponavljanje_racun
{
    class Program
    {
        static void Main(string[] args)
        {
            Racun r1 = new Racun();
            r1.Stavke.Add(new Stavka("Čokolada", 4, 7.99));
        }
    }
}
