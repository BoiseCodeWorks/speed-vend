using vendmachine.Interfaces;

namespace vendmachine.Models
{
    abstract class Food : IPurchasable
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public bool SugarFree { get; set; }

        public Food(double price, string name, int quant, bool sf)
        {
            Price = price;
            Name = name;
            Quantity = quant;
            SugarFree = sf;
        }
    }
}