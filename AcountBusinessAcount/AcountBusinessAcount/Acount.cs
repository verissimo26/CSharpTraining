
namespace AcountBusinessAcount
{
    internal class Acount
    {
        public int NumberAcount { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }


        public Acount() 
        { 
        }

        public Acount(int numberAcount, string holder, double balance) 
        {
            NumberAcount = numberAcount;
            Holder = holder;
            Balance = balance;
        }
        public void Withdraw (double amount)
        {
            Balance -= amount;
        }

        public void Deposit  (double amount)
        {
            Balance += amount;
        }
    }

   


    
 }
