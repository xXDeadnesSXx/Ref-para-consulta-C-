using System;

namespace DCP_OMNI.Services.Exceptions
{
    public class DbConcurrencyException : ApplicationException
    {//exceção personalizada para a camada de serviço
        public DbConcurrencyException(string message) : base(message)
        {

        }
    }
}
