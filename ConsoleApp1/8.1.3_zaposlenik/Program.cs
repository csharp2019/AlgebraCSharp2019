using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._3_zaposlenik
{
    class Program
    {
        static void Main(string[] args)
        {
           // Prvi način
           // Novi objekt Zaposlenik
           // Zaposlenik Z1 = new Zaposlenik("Josip", "Josipovic", "8788593686856");
           // Zaposlenik Z2 = new Zaposlenik("Luka", "Lukovsipovic");
            
           // List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>();
           // listaZaposlenika.Add(Z1);
           // listaZaposlenika.Add(Z2);

            // drugi način
            List<Zaposlenik> listaZaposlenika = new List<Zaposlenik>
            {
                 new Zaposlenik("Josip", "Josipovic", "8788593686856"),
                 new Zaposlenik("Luka", "Lukovsipovic")
            };


            listaZaposlenika.ForEach(Zaposlenik => UnesiBodove(Zaposlenik));
            listaZaposlenika.ForEach(Zaposlenik => UnesiVrijednostBoda(Zaposlenik));
            listaZaposlenika.ForEach(Zaposlenik => IspisiZaposlenike(Zaposlenik));


            Console.ReadKey();
        }

        private static void IspisiZaposlenike(Zaposlenik zaposlenik)
        {
            // ispis
            Console.WriteLine("Zaposlenik:" + zaposlenik.Ime + "" + zaposlenik.Prezime);
            Console.WriteLine("Neto:" + zaposlenik.NetoIzracunPlace());
            Console.WriteLine("Porez:" + zaposlenik.Porez);
            Console.WriteLine("Bruto" + zaposlenik.BrutoIzracunPlace());
        }

        private static void UnesiVrijednostBoda(Zaposlenik zaposlenik)
        {
            bool provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Unesite vrijednost boda:");
                try
                {
                    zaposlenik.VrijednostBoda = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("Greška" + ex.Message);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Greška" + ex.Message);
                }
            }
        }

        private static void UnesiBodove(Zaposlenik zaposlenik)
        {
            // Korisnik mora ispravno uneti broj bodova
            bool provjeraUnosa = false;
            while (!provjeraUnosa)
            {
                Console.Write("Unesite broj bodova");

                try
                {
                    zaposlenik.BrojBodova = double.Parse(Console.ReadLine());
                    provjeraUnosa = true;
                }

                catch (FormatException ex) // specijalne greške
                {
                    Console.WriteLine("Greška:" + ex.Message);
                }
                catch (Exception ex)// ostale greške
                {
                    Console.WriteLine("Greška" + ex.Message);
                }
            }
        }
    }
}
