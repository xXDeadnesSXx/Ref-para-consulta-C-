﻿using System;
using System.Collections.Generic;
using System.Text;
using Aula123SistemaCompletoPedidos.Entities.Enums;

namespace Aula123SistemaCompletoPedidos.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return
                Product.Name
                + ", R$"
                + Price.ToString("F2")
                + ", Quantity: "
                + Quantity
                + "Subtotal: R$ "
                + SubTotal().ToString("F2");
        }
    }
}
