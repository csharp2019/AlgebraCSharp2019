using System;
namespace _8._1._2_Prirucnuik
{
    internal class Ucenik
    {
        private string ime = "";
        public DateTime datumNastanka;
        public string prezime = "";
        public int ocjenaIzMatematike = 0;
        public int ocjenaIzEngleskog = 0;
        public int ocjenaIzBiologije = 0;

        public string Ime {
            get => ime;
            set => ime = ToUpper.FirstCharToUpper(value);
        }

        public Ucenik()
        {
            this.datumNastanka = DateTime.Now;

        }

        public Ucenik(string v)
        {
            this.Ime = v;
        }
        public Ucenik(string v, string prez)
        {
            this.Ime = v;
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
            return "Moje ime je " + this.Ime + " a moj prosjek je: " + this.Prosjek();
        }
    }
}