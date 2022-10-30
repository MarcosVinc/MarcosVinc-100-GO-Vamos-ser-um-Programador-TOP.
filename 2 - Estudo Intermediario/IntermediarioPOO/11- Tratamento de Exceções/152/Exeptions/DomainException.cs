using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO._11__Tratamento_de_Exceções._152.Exeptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string messege) : base(messege) 
        { 
        
        }
    }
}
