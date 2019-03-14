using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._1_krug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesi opseg kruga: ");
            double ops = double.Parse(Console.ReadLine());

            Console.WriteLine("radijus kruga s opsegom {0} je {1}.", ops, RadijusKruga(ops));
            Console.WriteLine("povrsina kruga s radijusom {0} je {1}.", RadijusKruga(ops), PovrsinaKruga(RadijusKruga(ops)));
   

            Console.ReadKey();

            Console.WriteLine("unesi radijus kruga: ");
            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("povrsina kruga s radijusom {0} je {1}.", r, PovrsinaKruga(r));
            Console.ReadKey();

        }
        static double RadijusKruga(double ops)
        {
            return ops / (2 * Math.PI);

        }
        static double PovrsinaKruga(double r)
        {
            return r * r * Math.PI;
        }
    }
}
