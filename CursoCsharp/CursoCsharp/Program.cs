using CursoCsharp;
using System.Net.Http.Headers;

Funcionario f1 = new Funcionario();
Funcionario f2 = new Funcionario();

Console.WriteLine("Digite o nome do Primeiro Funcionario");
f1.Nome = Console.ReadLine();
Console.WriteLine("Salario");
f1.Salario = double.Parse(Console.ReadLine());


Console.WriteLine("Digite o nome do Segundo Funcionario");
f2.Nome = Console.ReadLine();
Console.WriteLine("Salario");
f2.Salario = double.Parse(Console.ReadLine());

double media = (f1.Salario + f2.Salario) / 2;
Console.WriteLine("Salario medio = " + media);





