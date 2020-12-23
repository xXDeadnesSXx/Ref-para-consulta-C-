using System;
using System.Collections.Generic;
using System.Text;

namespace Aula123SistemaCompletoPedidos.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string email { get; set; }
        public DateTime Date { get; set; }

        public Client()
        {
        }
        public Client(string name, string email, DateTime date)
        {
            Name = name;
            this.email = email;
            Date = date;
        }
    }
}
