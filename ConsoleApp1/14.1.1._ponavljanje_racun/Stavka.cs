using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14._1._1._ponavljanje_racun
{
    public class Stavka : IStavka
    {
        private string v1;
        private int v2;
        private double v3;

        public Stavka(string v1, int v2, double v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public string NazivProizvoda { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Kolicina { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public decimal Cijena { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public decimal UkupnaCijena()
        {
            throw new NotImplementedException();
        }
    }
}