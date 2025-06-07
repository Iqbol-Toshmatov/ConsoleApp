using System;
using System.Threading.Channels;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int , string> phoneBook = new Dictionary<int , string>();
            phoneBook.Add(1234,"Tom");
            foreach (var names in phoneBook)
            {
                Console.WriteLine($"{names.Value} - {names.Key}");
            }
            var containsCode = phoneBook.ContainsKey(1234);
            Console.WriteLine(containsCode);
            var containsValue = phoneBook.ContainsValue("Bob");
            Console.WriteLine(containsValue);

        }
    }

}

