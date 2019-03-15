using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14._1._1._ponavljanje_racun
{
    public interface IStavka
    {
        string NazivProizvoda { get; set; }
        int Kolicina { get; set; }
        decimal Cijena { get; set; }

        decimal UkupnaCijena();
    }
}