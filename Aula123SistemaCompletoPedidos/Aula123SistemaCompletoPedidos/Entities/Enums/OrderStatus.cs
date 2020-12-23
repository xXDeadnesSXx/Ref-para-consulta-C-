using System;
using System.Collections.Generic;
using System.Text;

namespace Aula123SistemaCompletoPedidos.Entities.Enums
{
    enum OrderStatus: int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
