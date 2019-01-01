using System;
using OrderProject.Entities.Enum;
using OrderProject.Entities;
using System.Globalization;

namespace OrderProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            String name = Console.ReadLine();

            Console.Write("Email: ");
            String email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birth = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birth);

            Console.WriteLine("--- Enter Order Data ---");

            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(status, client);

            Console.Write("How many items to this order? ");
            int qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Enter #" + i + " item data");

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Product Price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(quantity, productPrice, product);
                order.addItem(orderItem);
            }

            Console.WriteLine(order.ToString());

        }
    }
}
