namespace IntermediarioPOO._10_Herança_e_Polimorfismo._136___Upcasting_e_downcasting
{
    class SavingsAccont : Account

    {
        public double InterestRate { get;  private set; }

        public SavingsAccont() { }
        public SavingsAccont( int number, string holder, double balance,double interesrate ) :
         base(number, holder, balance)
        {
            InterestRate = interesrate;
        }

        public void updateBalance() 
        {
            Balance += Balance * InterestRate;
          
        }
    }
}
