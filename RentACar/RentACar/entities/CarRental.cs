
namespace RentACar.entities
{
    internal class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Veicles Veicles { get; set; }
        public  Invoices Invoices { get; set; }

        public CarRental(DateTime start, DateTime finish, Veicles veicles)
        {
            Start = start;
            Finish = finish;
            Veicles = veicles;
        }
    }




}
