using Generics;

PrintService printService = new PrintService();
Console.WriteLine("How many values ?");
int n = int.Parse(Console.ReadLine());

for  (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    printService.AddValue(x);
}
printService.print();
Console.Write(" First : " + printService.First);