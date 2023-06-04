using System.Globalization;

class Employee
{
    public int ID { get; set; }
    public string Nome { get; set; }
    public double Salario { get; set; }

    public Employee(int id, string nome, double salario)
    {
        ID = id;
        Nome = nome;
        Salario = salario;
    }

    public void AumentoSalario (double porcentagem)
    {
        Salario += Salario * porcentagem / 100;
    }



    
}