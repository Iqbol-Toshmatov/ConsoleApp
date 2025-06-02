using System;
using System.Threading.Channels;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(200);
            account.Register(PrintMessage);
            account.Add(200);
            account.Take(100);
            account.Take(400);

            void PrintMessage(string message)=>Console.WriteLine(message);
        }
    }

    public delegate void Message(string message);

    public class Account
    {
        int sum;
        Message? taken;

        public void Register(Message del)
        {
            taken = del;
        }

        public Account(int sum)
        {
            this.sum = sum;
        }


        public void Add(int sum)
        {
            this.sum += sum;
            taken?.Invoke($"\nПриход {sum} у.е. \n\tБаланс: {this.sum} у.е.");

        }

        public void Take(int sum)
        {
            if (sum <=this.sum)
            {
                this.sum -= sum;
                taken?.Invoke($"\nСо счета списано {sum} у.е. \n\tБаланс: {this.sum} у.е.");
            }
            else
                taken?.Invoke($"\nНедостаточно средств. Вы пытались списать {sum} \nБаланс: {this.sum} у.е.");
        }
    }
}


