using System;
namespace _8._3._1_nasljedjivanje
{
    internal class Ucenik : Osoba, IUcenik
    {
       // private string ime = "";
       // public DateTime datumNastanka;
       // public string prezime = "";
        public int ocjenaIzMatematike = 0;
        public int ocjenaIzEngleskog = 0;
        public int ocjenaIzBiologije = 0;
        private Ispit prijavljeniIspit;

        // ovaj radi samo kod dirktnog poziva:
        // Ucenik u99=new Ucenik();
        public Ucenik()
        {
            this.datumNastanka = DateTime.Now;
            Console.WriteLine("Pozvana metoda Ucenik:Ucenik()");

        }

        public Ucenik(string v):base()
        {
            this.Ime = v;
        }
        public Ucenik(string v, string prez) : this (v)
        {
           // this.Ime = v;
            this.prezime = prez;
        }

        public void PrijaviIspit(Ispit ispit)
        {
            this.prijavljeniIspit = ispit;
            Console.WriteLine("Uspješno ste prijavili ispit " + this.prijavljeniIspit.Naziv);
        }

        public double Prosjek()
        {
            double prosjek = 0;
            prosjek = (double)(ocjenaIzBiologije + ocjenaIzEngleskog + ocjenaIzMatematike) / 3;

            return prosjek;
            //throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Moje ime je " + this.Ime + " a moj prosjek je: " + this.Prosjek()
                +" ja sam tipa:"+this.GetType();
        }
    }
}