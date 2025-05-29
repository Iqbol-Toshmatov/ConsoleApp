using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "Alice" };

            Employee employee = new Employee {Name="Tom" };

            employee.Company = "Microsoft";

            person.Print();

            employee.Print();
        }
    }
}


class Person
{
    public string Name { get; set; }

    public virtual void Print()
    {
        Console.WriteLine(Name);
    }
}

class Employee : Person
{
    public string? Company { get; set; }

    public override void Print()
    {
        Console.WriteLine($"{Name} works at {Company}");
    }
}