using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string mensagem) : base(mensagem) { }
    }
}
