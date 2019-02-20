using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Probna : IProbna
    {
        private int a = 10;
        public int b = 10;

        public int A { get => a; set => a = value; }

        public Probna() => this.A = 20;

        public int Add(int a, int b)
        {
            return a + b;
            //throw new NotImplementedException();
        }
    }
}
