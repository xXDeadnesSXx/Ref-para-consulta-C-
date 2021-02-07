using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DCP_OMNI.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {//exceção personalizada para a camada de serviço
        public DbConcurrencyException(string message) : base(message)
        {

        }
    }
}
