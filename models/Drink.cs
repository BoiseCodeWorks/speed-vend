using vendmachine.Interfaces;

namespace vendmachine.Models
{
    abstract class Drink : IPurchasable
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double FlOz { get; set; }

        public Drink(double price, string name, int quant, double flOz)
        {
            Price = price;
            Name = name;
            Quantity = quant;
            FlOz = flOz;
        }
    }
}