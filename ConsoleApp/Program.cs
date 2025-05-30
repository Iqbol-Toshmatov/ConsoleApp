using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person<int> tom = new Person<int>(1, "Tom");
            Console.WriteLine($"Id : {tom.Id} Name : {tom.Name} ");

            Person<string> bob = new Person<string>("qwerty", "Bob");
            Console.WriteLine($"Id : {bob.Id} Name : {bob.Name} ");

            Company<Person<int>> company = new Company<Person<int>>(tom);
            Console.WriteLine($"CEO of company : {company.CEO.Name}");
        }
    }

    public class Person<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }



        public Person(T id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Company<P>
    { 
        public P CEO { get; set; }

        public Company(P ceo)
        {
            CEO = ceo;  
        }
    }


}


