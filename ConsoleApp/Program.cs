using System;
using System.Threading.Channels;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Person> patiens = new Queue<Person>() ;
            patiens.Enqueue(new Person("Tom"));
            patiens.Enqueue(new Person("Sam"));
            patiens.Enqueue(new Person("Bob"));
            patiens.Enqueue(new Person("Tim"));

            Doctor doctor = new Doctor();
            doctor.TakePatiens(patiens);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name=name;  
        }
    }

    class Doctor
    {
        public void TakePatiens(Queue<Person> patiens)
        {
            while (patiens.Count>0)
            {
                var patien = patiens.Dequeue();
                Console.WriteLine($"Осмотр пациента {patien.Name}");
            }

            Console.WriteLine("Queue is empty!");
        }
    }
}

