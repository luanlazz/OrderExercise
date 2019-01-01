using System;
using OrderProject.Entities.Enum;
using System.Collections.Generic;
using System.Text;


namespace OrderProject.Entities
{
    public class Order
    {
        public DateTime moment { get; set; }
        public OrderStatus status { get; set; }
        public Client client { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem> { };

        public Order()
        {
        }

        public Order(OrderStatus status, Client client)
        {
            this.moment = DateTime.Now;
            this.status = status;
            this.client = client;
        }

        public void addItem(OrderItem item)
        {
            this.OrderItem.Add(item);
        }

        public void removeItem(OrderItem item)
        {
            this.OrderItem.Remove(item);
        }

        public double Total()
        {
            double total = 0;

            foreach (OrderItem item in OrderItem) {
                total += item.SubTotal();
            }

            return total;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.AppendLine("--- ORDER SUMMARY ---");
            str.AppendLine("Order Moment: " + this.moment);
            str.AppendLine("Order Status: " + this.status);
            str.AppendLine(client.ToString());
            str.AppendLine("Order Itens:");
            foreach (OrderItem item in OrderItem)
            {
                str.AppendLine(item.ToString());
            }
            str.AppendLine("Total price: $" + this.Total());

            return str.ToString();
        }
    }
}
