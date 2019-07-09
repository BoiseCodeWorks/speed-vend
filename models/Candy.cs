namespace vendmachine.Models
{
    class Candy : Food
    {
        public bool Chocolate { get; set; }
        public Candy(double price, string name, int quant, bool sf, bool chocolate) : base(price, name, quant, sf)
        {
            Chocolate = chocolate;
        }
    }
}