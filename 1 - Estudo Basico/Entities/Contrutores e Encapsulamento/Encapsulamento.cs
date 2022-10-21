using System;
using System.Collections.Generic;
using System.Text;

namespace BasicoPOO.Entities.Contrutores_e_Encapsulamento
{
    class Encapsulamento
    {
        private decimal _conta;

        public void SetConta(decimal add)
        {
            _conta = add;
        }

        public decimal AdicionarAConta(decimal adicionar)
        {
            return _conta += adicionar;
        }
        public void RetirarValor(decimal retirar)
        {
            _conta -= retirar;
        }

        public override string ToString()
        {
            return "Banco do Brasil: Valor em saldo: " + _conta;
        }
    }
}
