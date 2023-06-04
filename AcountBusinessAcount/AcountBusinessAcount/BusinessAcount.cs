namespace AcountBusinessAcount
{
    internal class BusinessAcount : Acount
    {
        public double LoanLimit { get; set; }

        public BusinessAcount()
        {

        }

        public BusinessAcount (int numberAcount, string holder, double balance, double loanLimit) : base(numberAcount, holder ,balance)
        {
            LoanLimit = loanLimit;

        }
        public void Loan (double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
            
        }
    }
}
