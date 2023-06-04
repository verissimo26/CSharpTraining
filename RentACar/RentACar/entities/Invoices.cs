
namespace RentACar.entities
{
    internal class Invoices
    {
        public double BaiscPayment { get; set; }
        public double Tax { get; set; }

        public Invoices(double baiscPayment, double tax)
        {
            BaiscPayment = baiscPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BaiscPayment + Tax; }
        }

        public override string ToString()
        {
            return "Basic Payment"
                + BaiscPayment.ToString("F2")
                + Tax.ToString("F2")
                + "\n"
                + TotalPayment.ToString("F2");
        }
    }
}
