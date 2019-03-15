using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14._1._1._ponavljanje_racun
{
    public class Racun : ARacun, IRacun
    {
        private string djelatnik;
        private string nazivKupca;
        public List<Stavka> Stavke = new List<Stavka>();
        public decimal IznosRacuna
        {
            get => default(int);
        }

        public string Djelatnik { get => djelatnik; set => djelatnik = value; }
        public string NazivKupca { get => nazivKupca; set => nazivKupca = value; }

        public void SpremiUDatoteku()
        {
            throw new System.NotImplementedException();
        }
    }
}