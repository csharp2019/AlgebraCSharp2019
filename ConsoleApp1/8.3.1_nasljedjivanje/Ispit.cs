namespace _8._3._1_nasljedjivanje
{
    public class Ispit
    {
        private string naziv="Matematika";
        private string v;

        public Ispit(string v)
        {
            this.Naziv = v;
        }

        public string Naziv { get => naziv; set => naziv = value; }
    }
}