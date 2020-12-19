using Aula115Enumeracao.Entities;
using Aula115Enumeracao.Entities.Enums;
using System;

namespace Aula115Enumeracao
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 123,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);
            Console.WriteLine( );
            Console.WriteLine("-------------------------------");
            //Passar de enum para string
            string s1 = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(s1);
            //fim
            //Passar de string para enum
            OrderStatus os1 = Enum.Parse<OrderStatus>(s1);
            OrderStatus os2 = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine("OS1: "+os1);
            Console.WriteLine("OS2: " + os2);
        }
    }
}
