using System;
using System.Collections.Generic;
using System.Text;
using Aula123SistemaCompletoPedidos.Entities.Enums;

namespace Aula123SistemaCompletoPedidos.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status{ get; set; }
        public Client _Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
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
    }
}
