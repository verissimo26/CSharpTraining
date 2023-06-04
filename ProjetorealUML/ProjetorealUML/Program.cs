using ProjetorealUML;
using ProjetorealUML.Enums;

Console.WriteLine("Digite o departamento ");
string deptname=Console.ReadLine();
Console.WriteLine("Enter Worker Data ");
Console.WriteLine("Name ");
string name = Console.ReadLine();
Console.WriteLine("Leve Junior / Midlevel / Senior ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.WriteLine("Base Salary ");
double baseSalary = double.Parse(Console.ReadLine());

Departiments dpt = new Departiments(deptname);
Worker worker = new Worker(name, level, baseSalary, dpt);

Console.WriteLine("How many contracts? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter the {n} contract");
    Console.WriteLine("Data ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Valor por hour");
    double valuePerHour = double.Parse(Console.ReadLine());
    Console.WriteLine("Duration ()Houers ");
    int hours = int.Parse(Console.ReadLine());
    HourContracts contract = new HourContracts(date, valuePerHour, hours);
    worker.AddContract(contract);

}

Console.WriteLine("");
Console.WriteLine("Entre com mes e ano MM/AAAA ");
string mounthYear = Console.ReadLine();
int mounth = int.Parse(mounthYear.Substring(0,2)) ;
int year = int.Parse(mounthYear.Substring(0, 3));

Console.WriteLine("Name" + worker.Name) ;
Console.WriteLine("Name" + worker.Departiments.Name);
Console.WriteLine("Income for " + mounthYear + " : " +worker.Income(year, mounth));






