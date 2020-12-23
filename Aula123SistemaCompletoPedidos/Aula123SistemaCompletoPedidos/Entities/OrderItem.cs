using System;
using System.Collections.Generic;
using System.Text;

namespace Aula123SistemaCompletoPedidos.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product _product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            _product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
