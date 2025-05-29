using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee {Name="Tom" };

            employee.Company = "Microsoft";

            employee.Print();

            employee.PrintCompany();
        }
    }
}


class Person
{
    public string Name { get; set; }

    public void Print()
    {
        Console.WriteLine(Name);
    }
}

class Employee : Person
{
    public string? Company { get; set; }

    public void PrintCompany()
    {
        Console.WriteLine($"{Name} works at {Company}");
    }
}