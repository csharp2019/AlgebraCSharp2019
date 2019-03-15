namespace _14._1._1._ponavljanje_racun
{
    public interface IRacun
    {
        string Djelatnik { get; set; }
        decimal IznosRacuna { get; }
        string NazivKupca { get; set; }

        void SpremiUDatoteku();
    }
}