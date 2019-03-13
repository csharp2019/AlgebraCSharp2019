using BusinessLayer;
namespace Operateri
{
    public class Pilot : Vozac
    {
        public Pilot(string v1, string v2) : base(v1, v2)
        {
        }

        public bool Kategorija_x { get; set; }

        public override string ToString()
        {

            if (this.Kategorija_x)
            {
                return base.ToString() + " X";
            }
            else
            {
                return base.ToString();
            }
            
        }
    }
}