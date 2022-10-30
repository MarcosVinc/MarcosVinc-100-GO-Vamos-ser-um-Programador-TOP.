using IntermediarioPOO._11__Tratamento_de_Exceções._155.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediarioPOO._11__Tratamento_de_Exceções._155.Entities
{
    class Account155
    {
        public int Number { get;  private set; }
        public string Holder { get; set; }
        public double Balance { get;  private set; }
        public double WithDrawLimit { get; set; }

        public Account155(int number, string holder, double balance, double withdraw) 
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withdraw;
        }
        public void deposit(double amount) 
        {
            Balance += amount;
        }
        public void withdraw(double amount) 
        {
            Balance -= amount;
        }

        public void ErrorSniper(double saque) 
        {

            if (saque > WithDrawLimit) 
            {
                throw new DomainExceptionAccont("The amount exceeds withdraw limit" );
            }
            if (saque > Balance) 
            {
                throw new DomainExceptionAccont("Not enough balance");
            } 
            
        }
    }
}
