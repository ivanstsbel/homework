using System;
using System.IO;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите строку :");
            string str = Console.ReadLine();
            string filename = "tex2t.txt";
            File.AppendAllText(filename, str); // записываем в файл строку

        }
    }
}
