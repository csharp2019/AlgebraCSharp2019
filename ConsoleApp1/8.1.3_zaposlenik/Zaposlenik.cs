using System;

namespace _8._1._3_zaposlenik
{
    internal class Zaposlenik
    {
        #region Svojstva

        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private string prezime;
        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        private string oib;
        public string OIB
        {

            get { return oib; }
            set { prezime = value; }
        }

        private double brojBodova;
        public double BrojBodova
        {
            get { return brojBodova; }
            set
            {
                if (value > 0)
                {
                    brojBodova = value;
                }

                else
                {
                    Exception ex = new Exception("Mozete uneti samo pozitivan broj");
                    throw ex;
                }
            }
        }

        double vrijednostBoda;
        public double VrijednostBoda
        {
            get { return vrijednostBoda; }
            set

            {
                if (value > 0)
                {
                    vrijednostBoda = value;
                }
                else
                {
                    Exception ex = new Exception("Mozete uneti samo pozitivan broj");
                    throw ex;
                }
            }
        }

        // ReadOnly svojstvo
        public double Porez
        {
            get
            {
                double neto = this.NetoIzracunPlace();
                if (neto < 3000)
                {
                    return neto * 0.06;
                }

                else if (neto < 6000)
                {
                    return neto * 0.12;
                }
                else
                {
                    return neto * 0.2;
                }
            }
        }



        #endregion

        #region  metode
        public double NetoIzracunPlace()
        {
            return this.BrojBodova * this.VrijednostBoda;
        }
        public double BrutoIzracunPlace()
        {
            return this.NetoIzracunPlace() + this.Porez;
        }

        #endregion

        #region Konstruktori

        public Zaposlenik() { }

        public Zaposlenik(string ime, string prezime)
        {

            this.Ime = ime;
            this.Prezime = prezime;
        }

        public Zaposlenik(string ime, string prezime, string oib) 
            :this(ime, prezime)
        {
           // this.Ime = ime;
           // this.Prezime = prezime;
            this.OIB = oib;
        }
        public Zaposlenik(string ime, string prezime, string oib, double brojbodova) 
            : this(ime, prezime, oib)
        {
            this.BrojBodova = brojbodova;
        }
        #endregion
    }
}