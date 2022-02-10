using System;
using System.Collections.Generic;
using System.Text;


namespace exercicio_enumeracao_composicao.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }
    }
}
