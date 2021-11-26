using System;
using System.Configuration;


namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Settings.Default.Hello}");
            if (string.IsNullOrEmpty(Settings.Default.UserName))
            {

                Console.WriteLine("Введите имя пользователя:");
                Settings.Default.UserName = Console.ReadLine();
                Console.WriteLine("Введите возраст пользователя:");
                Settings.Default.Age= Console.ReadLine();
                Console.WriteLine("Введите род деятельности:");
                Settings.Default.TipsJob = Console.ReadLine();
                Settings.Default.Save();

            }
            string userName = Settings.Default.UserName;
            string Age = Settings.Default.Age;
            string Tipsjob = Settings.Default.TipsJob;
            string hello = Settings.Default.Hello;
            
            Console.WriteLine($"{hello} {userName}! Ваш возраст: {Age} Род деятельности: {Tipsjob}");
            
        }
    }
}
