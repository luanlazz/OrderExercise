using System;
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
    }
}
