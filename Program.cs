using System;
using exercicio_enumeracao_composicao.Entities;
using exercicio_enumeracao_composicao.Enums;
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


            for (int i = 1; i < n; i++)
            {
                Console.Write("Entre as info do produto #" + i);
                Console.WriteLine("Nome do produto: ");
                string prodnome = Console.ReadLine();
                Console.WriteLine("Preço do produto: ");
                double preco = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade do produto: ");
                int quantidade = int.Parse(Console.ReadLine());


            }
        }
    }
}
