namespace IntermediarioPOO._10_Herança_e_Polimorfismo._135___Herença
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; private set; }
        public BusinessAccount()
        {
        }
        public BusinessAccount(int number, string holder, double balance, double loanlimit)
        : base(number, holder, balance) 
        {
            LoanLimit = loanlimit;
        
        }

        public void Loan(double amount) 
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }


    }
}
