using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO._11__Tratamento_de_Exceções._155.Exceptions
{
    class DomainExceptionAccont : ApplicationException
    {
        public DomainExceptionAccont(string messege):base(messege) { }
    }
}
