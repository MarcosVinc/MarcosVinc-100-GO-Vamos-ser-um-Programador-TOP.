using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BasicoPOO.Entities.Contrutores_e_Encapsulamento
{
    class ContaBancaria
    {
        #region Propriedades auto implementadas
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        #endregion

        #region Constutores
        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Deposito(saldo);

        }
        #endregion

        #region Propriedades Customizadas
        public double Deposito(double quantia)
        {
            return Saldo += quantia;

        }
        public double Saque(double quantia)
        {
            return Saldo -= quantia + 5;
        }
        public override string ToString()
        {
            return
            "Conta: " + Numero + ", Titular: " + Titular + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
        #endregion
    }
}
