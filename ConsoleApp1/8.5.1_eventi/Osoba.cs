using System;

namespace _8._5._1_eventi
{
    internal class Osoba
    {
        public delegate void NaPromjenuImenaDelegat(object sender, EventArgs e);
        public event NaPromjenuImenaDelegat NaPromjenuImena;

        private string ime;
        public string Ime
        {
            get { return ime; }
            set
            {
                ime = value;
                if (NaPromjenuImena != null)
                {
                    NaPromjenuImena(this, new EventArgs());
                }
            }
        }
    }
}