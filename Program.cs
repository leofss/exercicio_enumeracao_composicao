using System;
using exercicio_enumeracao_composicao.Entities;
using exercicio_enumeracao_composicao.Enums;
using System.Collections.Generic;
namespace exercicio_enumeracao_composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            /*OrderItem orderItem = new OrderItem();
            Order order = new Order();
            Client client = new Client();*/

            Console.WriteLine("Entre nome do cliente ");
            string name = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Data de aniversario: ");
            string dateofbirth = Console.ReadLine();
            Console.WriteLine("Status do pedido: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("Quantos pedidos: ");
            int n = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, dateofbirth);
            Order order = new Order(DateTime.Now, status, client);


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nome do produto: ");
                string prodname = Console.ReadLine();
                Console.WriteLine("Preço do produto: ");
                double pricepd = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade do produto: ");
                int qnt = int.Parse(Console.ReadLine());

                Product product = new Product(prodname, pricepd);
                OrderItem orderItem = new OrderItem(qnt, pricepd, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);



        }
    }
}
