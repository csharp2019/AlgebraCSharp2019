using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ucenik> listaUcenika = new List<Ucenik>()
            {
                new Ucenik("Marko", " Marić "),
                new Ucenik("Pero", " Perić ", " 1234567890 "),
                new Ucenik("Pero", " Perić ", " 1234567890 ", 3000),
            };

            // Elegantno rješenje skolarine:
            //  listaUcenika.ForEach(Ucenik => Ucenik.Racun -= skoloarina);


            listaUcenika.ForEach(Ucenik => IspisOsnovni(Ucenik));
            listaUcenika.ForEach(Ucenik => UnesiVrijednost(Ucenik));
            listaUcenika.ForEach(Ucenik => IspisiUcenike(Ucenik));

            Console.ReadKey();
        }

        private static void IspisOsnovni(Ucenik ucenik)
        {
            Console.WriteLine(ucenik.ToString());
        }

        private static void UnesiVrijednost(Ucenik ucenik)
        {
            double skolarina = 0;
            try
            {
                Console.WriteLine("Unesi iznos skolarine ucenika");
                skolarina = double.Parse(Console.ReadLine());
                Console.WriteLine("Unesi broj telefona ucenika");
                ucenik.telefon = Console.ReadLine();
                Console.WriteLine("Unesi OIB ucenika");
                ucenik.telefon = Console.ReadLine();
            }
            catch (FormatException fex)
            {
                Console.WriteLine("Nepravilan format unosa." + fex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Nepravilan unos." + ex.Message);
            }
            finally
            {
                ucenik.Racun = ucenik.Racun - skolarina;
            }
        }

        private static void IspisiUcenike(Ucenik ucenik)
        {
            Console.WriteLine(ucenik.ToString());
            Console.WriteLine("Telefon: " + ucenik.telefon);
        }
    }
}
