using System;
namespace _8._1._2_Prirucnuik
{
    internal class Ucenik
    {
        public string ime = "";
        public DateTime datumNastanka;
        public string prezime = "";
        public int ocjenaIzMatematike = 0;
        public int ocjenaIzEngleskog = 0;
        public int ocjenaIzBiologije = 0;

        public Ucenik()
        {
            this.datumNastanka = DateTime.Now;

        }

        public Ucenik(string v)
        {
            this.ime = v;
        }
        public Ucenik(string v, string prez)
        {
            this.ime = v;
            this.prezime = prez;
        }

        internal double Prosjek()
        {
            double prosjek = 0;
            prosjek = (double)(ocjenaIzBiologije + ocjenaIzEngleskog + ocjenaIzMatematike) / 3;

            return prosjek;
            //throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Moje ime je " + this.ime + " a moj prosjek je: " + this.Prosjek();
        }
    }
}