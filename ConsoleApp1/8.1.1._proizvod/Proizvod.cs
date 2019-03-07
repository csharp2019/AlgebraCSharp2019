using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._1._proizvod
{
    class Proizvod
    {
        // Polja
        public string Naziv = "";
        public double Cijena = 0;
        public double Marza = 0;
        public double Porez = 0;

        // Metode
        public Proizvod(string naziv)
        {
            Naziv = naziv;
        }
        public double MPC()
        {
            return Cijena + Marza + Porez;
        }
    }

}