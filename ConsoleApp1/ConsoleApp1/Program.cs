using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello , {name}! Now {DateTime.Now}!");
        }
    }
}
