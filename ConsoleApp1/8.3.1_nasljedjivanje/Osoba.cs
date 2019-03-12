using System;
using _8._1._2_Prirucnuik;

namespace _8._3._1_nasljedjivanje
{
    public abstract class Osoba
    {
        public DateTime datumNastanka;
        public string prezime = "";
        private string ime = "";

        public string Ime
        {
            get => ime;
            set => ime = ToUpper.FirstCharToUpper(value);
        }

        public Osoba()
        {
            this.datumNastanka = DateTime.Now;
            Console.WriteLine("Pozvana metoda Osoba:Osoba()");
        }

        protected Osoba(string v1, string v2)
        {
            this.ime = v1;
            this.prezime = v2;
        }
    }
}