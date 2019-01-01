using System;
using System.Text;
using System.Globalization;

namespace OrderProject.Entities
{
    public class OrderItem
    {
        public int quantity { get; set; }
        public double price { get; set; }
        public Product product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            this.quantity = quantity;
            this.price = price;
            this.product = product;
        }

        public double SubTotal()
        {
            return quantity * price;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(product);
            str.Append(", ");
            str.Append("$" + this.price);
            str.Append(", ");
            str.Append("Quantity: " + this.quantity);
            str.Append(", ");
            str.Append("Subtotal: $" + SubTotal().ToString("F2", CultureInfo.InvariantCulture));

            return str.ToString();
        }
    }
}
