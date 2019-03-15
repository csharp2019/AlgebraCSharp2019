using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._1_enumeracije
{
    public enum RadniDani
    {
        Ponedjeljak = 1,
        Utorak,
        Srijeda,
        Cetvrtak,
        Petak
    }
    public enum Ocjene
    {
        Nedovoljan = 1,
        Dovoljan,
        Dobar,
        Vrlodobar,
        Odlican
    }
    public enum Katovi
    {
        Prizemlje,
        Prvi,
        Drugi,
        Treci,
        Cetvrti
    }
    class Program
    {
        static void Main(string[] args)
        {
            Firma algebra = new Firma("Algebra d.o.o.");
            algebra.Kat = Katovi.Treci;
            Console.WriteLine(algebra);
            Console.ReadKey();

        }
    }
    class Firma
    {
        private Katovi kat;
        private string naziv;

        public Firma(string v)
        {
            this.Naziv = v;
        }

        public Katovi Kat { get => kat; set => kat = value; }
        public string Naziv { get => naziv; set => naziv = value; }
        public override string ToString()
        {
            string kojiKat = "";
            switch ((int)kat)
            {
                case 0: kojiKat = "nultom"; break;
                case 1:  kojiKat = "prvom"; break;
                case 2: kojiKat = "drugom"; break;
                case 3: kojiKat = "trećem"; break;
                case 4: kojiKat = "četvrtom"; break;
                default: kojiKat = "nepoznatom"; break;
            }

            return "Inaše ime je " + this.naziv + " i nalazimo se na " + kojiKat + " katu";

        }
    }
}
