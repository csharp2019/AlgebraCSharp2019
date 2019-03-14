using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._1._2_datoteke_dirs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapa u kojoj se izvršava naš program: ");
            Console.WriteLine(Environment.CurrentDirectory);

            Console.WriteLine("Postoji li file Proba.txt u izvršnoj mapi: ");
            // Path klasa
            string mojaPutanja = Path.Combine(Environment.CurrentDirectory, "Proba.txt");

            // File klasa
            Console.WriteLine(File.Exists(mojaPutanja));

            // Directory klasa
            if (!Directory.Exists("Proba"))
            {
                // Ako ne postoji folder Proba, kreiram ga
                Directory.CreateDirectory("Proba");
            }

            // Ispisujem sve foldere na C-u
            Console.WriteLine("Direktoriji na C:");
            string[] sDirs = Directory.GetDirectories(@"C:\");
            foreach (string sDir in sDirs)
            {
                Console.WriteLine(sDir);
            }

            // Ispisujem sve fileove na C-u
            Console.WriteLine("Datoteke na C:");
            string[] sFiles = Directory.GetFiles(@"C:\");
            foreach (string sFile in sFiles)
            {
                Console.WriteLine("\nsFile:");
                Console.WriteLine(sFile);

                Console.WriteLine("\nsPath.getfilename:");
                Console.WriteLine(Path.GetFileName(sFile));

                Console.WriteLine("\nsPath.getextension:");
                Console.WriteLine(Path.GetExtension(sFile));

                Console.WriteLine("\nsPath.getextension:");
                Console.WriteLine(File.GetCreationTime(sFile));

            }

            Console.ReadKey();
        }
    }
}
