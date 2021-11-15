using System;
using System.IO;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime();
            string filename = "startup.txt";
            string time = ($"{DateTime.Now}");
            File.AppendAllText(filename, time); // записываем в файл строк
            Console.WriteLine($"Время и дата {DateTime.Now} записаны в файл");
        }
    }
}
