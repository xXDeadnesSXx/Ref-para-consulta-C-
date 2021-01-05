using System;
using System.Collections.Generic;
using System.Text;
using Aula123SistemaCompletoPedidos.Entities.Enums;

namespace Aula123SistemaCompletoPedidos.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
<<<<<<< HEAD
        public Product Product { get; set; }
=======
        public Product _product { get; set; }
>>>>>>> d21e1d489fa0c4139b245ca7fa594165e83c3740

        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
<<<<<<< HEAD
            Product = product;
=======
            _product = product;
>>>>>>> d21e1d489fa0c4139b245ca7fa594165e83c3740
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
<<<<<<< HEAD

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
=======
>>>>>>> d21e1d489fa0c4139b245ca7fa594165e83c3740
    }
}
