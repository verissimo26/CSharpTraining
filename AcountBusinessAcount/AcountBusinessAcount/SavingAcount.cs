namespace AcountBusinessAcount
{
    internal class SavingAcount : Acount
    {
        public double InterestRate { get; set; }

        public SavingAcount()
        {
        }
        public SavingAcount (int numberAcount, string holder, double balance, double InterestRate) 
        : base (numberAcount, holder, balance)
        {
            InterestRate = InterestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

    }

    
}
