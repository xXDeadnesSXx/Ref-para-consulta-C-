using System;
using System.Collections.Generic;
using System.Text;
using Aula123SistemaCompletoPedidos.Entities.Enums;

namespace Aula123SistemaCompletoPedidos.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
<<<<<<< HEAD
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
=======
        public OrderStatus Status{ get; set; }
        public Client _Client { get; set; }
>>>>>>> d21e1d489fa0c4139b245ca7fa594165e83c3740
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
<<<<<<< HEAD
            Client = client;
        }
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach(OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: "+Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price R$ "+Total().ToString("F2"));
            return sb.ToString();
        }
=======
            _Client = client;
        }
        public void AddProduct(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveProduct(OrderItem item)
        {
            Items.Remove(item);
        }
>>>>>>> d21e1d489fa0c4139b245ca7fa594165e83c3740
    }
}
