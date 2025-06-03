using System;
using System.Threading.Channels;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message { Text = "Hello, World!" };
            message.Print();
        }
    }

    interface IMessage
    { 
        string Text { get; set; }
    }

    public interface IPrintable
    {
        void Print();
    }

    class Message : IMessage, IPrintable
    {
        public string? Text { get; set; }

        public void Print()
        {
            Console.WriteLine(Text);
        }
    }

}

