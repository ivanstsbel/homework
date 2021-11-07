using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку :");
            string str = Console.ReadLine();
            Console.WriteLine("Строка наоборот :");
            for (int i = str.Length-1; i >= 0; i--)
                Console.Write($"{str[i]}");
        }
    }
}
