using ExerciciosContaBancaria;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        ContaBancaria conta;

        Console.WriteLine("Entre com numero da conta: ");
        int numero = int.Parse(Console.ReadLine());
        Console.WriteLine("Entre o titular da conta: ");
        string titular = Console.ReadLine();
        Console.WriteLine("Deposito inicial?: ");
        char resp = char.Parse(Console.ReadLine());
        {
            if (resp == 'S' || resp == 's')
            {
                Console.WriteLine("Entre com o valor do deposito inicial ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);
            }

            else conta = new ContaBancaria(numero, titular);
        }

        Console.WriteLine();
        Console.WriteLine("Dados da conta: ");
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.WriteLine("Entre valor do deposito R$:");
        double quantia = double.Parse(Console.ReadLine());
        conta.Deposito(quantia);
        Console.WriteLine("Dados atualizados " );
        Console.WriteLine(conta);

        Console.WriteLine();
        Console.WriteLine("Entre valor do Saque R$: ");
        quantia = double.Parse(Console.ReadLine());
        conta.Saque(quantia);
        Console.WriteLine("Dados atualizados " );
        Console.WriteLine(conta);
    }
}