using System;
using System.Threading.Channels;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> {"Tom", "Sam", "Bob" };

            List<Person> personNames = new List<Person>()
            {
                new Person("Alice"),
                new Person("Tommy"),
                new Person("Jimmy")
            };

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.Add("John");
            names.AddRange(new[] {"Bib","Tim" });
            names.Insert(0,"Me");

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            names.Remove("Tom");
            names.RemoveAt(1);
            names.RemoveAll(name => name.Length < 3);
            names.Clear();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            var excistsLength2 = names.Exists(name => name.Length == 2);
            Console.WriteLine(excistsLength2);

            names.Reverse();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }


        }
    }

    class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }

}

