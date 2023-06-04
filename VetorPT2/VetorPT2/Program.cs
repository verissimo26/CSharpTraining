using VetorPT2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Quantidade de Produtos");
        int n = 0; int.Parse(Console.ReadLine());

        Produto[] vect = new Produto[n];
        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            vect[i] = new Produto { Name = name, Price = price };
        }
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum = sum + vect[i].Price;
        }

        double avg = sum / n;
        Console.WriteLine("AVG PRICE =" + avg);
    }
}