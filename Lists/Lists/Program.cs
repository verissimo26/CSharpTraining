﻿using System.Collections.Generic;
using System.Globalization;

Console.WriteLine("Quantos funcionarios deseja registrar ?"); 
int n = int.Parse(Console.ReadLine());

List<Employee> list = new List<Employee>();
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Employee #" + i + ":");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
}
for (int i = 1; i <= n; i++)
{
    Console.WriteLine("Employee #" + i + ":");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    list.Add(new Employee(id, name, salary));
    Console.WriteLine();
}

Console.Write("Enter the employee id that will have salary increase : ");
int searchId = int.Parse(Console.ReadLine());

Employee emp = list.Find(x => x.ID == searchId);
if (emp != null)
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    emp.AumentoSalario(percentage);
}
else
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine();
Console.WriteLine("Updated list of employees:");
foreach (Employee obj in list)
{
    Console.WriteLine(obj);
}

