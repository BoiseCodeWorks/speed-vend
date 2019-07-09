namespace vendmachine.Models
{
    class Chips : Food
    {
        public bool Spicy { get; set; }
        public Chips(double price, string name, int quant, bool sf, bool spicy) : base(price, name, quant, sf)
        {
            Spicy = spicy;
        }
    }
}