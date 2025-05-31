using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 5;
                int y = x / 1;
                Console.WriteLine(y);


            }
            catch
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("End of program");
            }
        }
    }

}


