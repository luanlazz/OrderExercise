using System;
using OrderProject.Entities.Enum;
using System.Collections.Generic;


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

        public double total()
        {
            double total = 0;

            foreach (OrderItem item in OrderItem) {
                total += item.subTotal();
            }

            return total;
        }
    }
}
