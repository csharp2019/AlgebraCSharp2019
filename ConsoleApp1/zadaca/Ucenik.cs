using System;

namespace zadaca
{
    internal class Ucenik
    {
        private string ime;
        public string Ime
        {
            get => ime;
        }

        private string prezime;
        public string Prezime
        {
            get => prezime;
        }

        private string oib;
        public string Oib
        {
            set => oib = value;
        }

        public string telefon;

        private double racun;
        public double Racun
        {
            get => racun;
            set => racun = value;
        }

        public override string ToString()
        {
            return "Pozdrav " + this.Ime + " " + this.prezime + this.racun;
        }

        public Ucenik(string Ime, string Prezime)
        {
            Random random = new Random();
            this.racun = random.Next(2000, 6000);
            this.ime = Ime;
            this.prezime = Prezime;
        }

        public Ucenik(string Ime, string Prezime, string Oib)
        {
            Random random = new Random();
            this.racun = random.Next(2000, 6000);
            this.ime = Ime;
            this.prezime = Prezime;
            this.oib = Oib;
        }

        public Ucenik(string Ime, string Prezime, string Oib, double Racun)
        {
            this.ime = Ime;
            this.prezime = Prezime;
            this.oib = Oib;
            this.racun = Racun;
        }
    }
}