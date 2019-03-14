namespace _8._1._2_Automobil
{
    public class Automobil
    {
        // Polja
        public string MarkaAutomobila = "";
        public double KS = 0;
        public double OsnovnaCijena = 0;

        // Metode
        public double IznosPoreza()
        {
            double postotak = 0;

            if (KS < 50)
            {
                postotak = 0.05;
            }
            else if (KS < 150)
            {
                postotak = 0.1;
            }
            else
            {
                postotak = 0.15;
            }

            return OsnovnaCijena * postotak;
        }
        public double UkupnaCijena()
        {
            return OsnovnaCijena + IznosPoreza();
        }
    }
}