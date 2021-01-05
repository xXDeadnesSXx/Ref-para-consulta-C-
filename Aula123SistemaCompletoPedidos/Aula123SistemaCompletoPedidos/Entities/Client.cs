using System;
using System.Collections.Generic;
using System.Text;

namespace Aula123SistemaCompletoPedidos.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client()
        {
        }
        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        public override string ToString()
        {
<<<<<<< HEAD
            return Name
                + " ("
                + BirthDate
                + ") - "
                + Email;
=======
            return
                Name +
                ", (" +
                BirthDate +
                ") - " +
                Email;
>>>>>>> d21e1d489fa0c4139b245ca7fa594165e83c3740
        }
    }
}
