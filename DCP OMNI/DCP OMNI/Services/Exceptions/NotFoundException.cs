using System;

namespace DCP_OMNI.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {//exceção personalizada para a camada de serviço
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
