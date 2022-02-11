using System;
using System.Collections.Generic;
using System.Text;
using exercicio_enumeracao_composicao.Entities;
using exercicio_enumeracao_composicao.Enums;
using System.Globalization;

namespace exercicio_enumeracao_composicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Client Client {get; set;}
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();


        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;

        }

        public void AddItem (OrderItem orderitem)
        {
            OrderItems.Add(orderitem);
        }

        public void RemoveItem (OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
        }


        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in OrderItems)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client.Name);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in OrderItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
