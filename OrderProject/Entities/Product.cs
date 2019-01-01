using System;
using System.Text;
namespace OrderProject.Entities
{
    public class Product
    {
        public String name { get; set; }
        public Double price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
