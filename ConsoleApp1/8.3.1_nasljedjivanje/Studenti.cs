using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _8._3._1_nasljedjivanje
{
    public class Studenti:System.Collections.CollectionBase
    {

        public int Add(object uc)
        {
            return base.InnerList.Add(uc);
        }
        public int Add(string ime, string prezime)
        {
            Ucenik uc = new Ucenik(ime, prezime);
            return base.InnerList.Add(uc);
        }
        public object this[int index]
        {
            get
            {
                return (Ucenik)base.InnerList[index];
            }
        }
    }
}
