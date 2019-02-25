using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._3.exceptio_primjer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Unesite cijeli broj: ");
                int a = int.Parse(Console.ReadLine());

                if (a > 0)
                {
                    Console.WriteLine("Uneseni broj je pozitivan");
                }
                else if (a < 0)
                {
                    Console.WriteLine("Uneseni broj je negativan");
                }
                else
                {
                    Console.WriteLine("Uneseni broj je jednak nuli");
                }


            }
            catch (FormatException fex)
            {
                Console.WriteLine("GREŠKA, Nije unešen numerički znak:"
                    + fex.Message
                    + "\n"
                    + fex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("GREŠKA, generička:" + ex.Message+ex.ToString());
            }
            finally
            {
             Console.ReadKey();
            }
            
        }
    }
}

