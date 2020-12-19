using System;
using Aula115Enumeracao.Entities.Enums;

namespace Aula115Enumeracao.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return 
                "Id do pedido: "+Id
                + ", Data: "+ Moment
                + ", Status: "+ Status;
        }
    }
}
