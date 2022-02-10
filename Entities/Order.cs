using System;
using System.Collections.Generic;
using System.Text;
using exercicio_enumeracao_composicao.Entities;
using exercicio_enumeracao_composicao.Enums;
using System.Collections.Generic;

namespace exercicio_enumeracao_composicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public string Status { get; set; }

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

        
    }
}
