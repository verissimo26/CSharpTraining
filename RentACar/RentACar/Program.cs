using RentACar.entities;
using RentACar.Services;

Console.WriteLine("Entre com dados do Veiculo");
Console.WriteLine("Car Model");
string model = Console.ReadLine();

Console.WriteLine("Entre com a data dd/mm/yyyy");
DateTime start = DateTime.Now;

Console.WriteLine("Entre com a data de retorno dd/mm/yyyy");
DateTime finish = DateTime.Now;

Console.WriteLine("Entre preco por hora");
double hour = double.Parse(Console.ReadLine());
Console.WriteLine("Entre preco por day");
double day = double.Parse(Console.ReadLine());

CarRental carRental = new CarRental(start, finish, new Veicles(model));

RentalService rentalService = new RentalService(hour,day);

rentalService.ProcessInovice(carRental);

Console.WriteLine("Invoice");
Console.WriteLine(carRental.Invoices);
