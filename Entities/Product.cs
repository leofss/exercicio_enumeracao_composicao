using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_enumeracao_composicao.Entities
{
    class Product
    {
        public string ProdName { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string prodName, double price)
        {
            ProdName = prodName;
            Price = price;
        }
    }
}
