using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fName = { "Алексей", "Петр", "Сергей", "Владимир"};
            string[] lName = { "Богомолов", "Кузнецов", "Медведев", "Иванов"};
            string[] pName = { "Иванович", "Александрович", "Владимирович", "Евгеньевич"};

            Random rnd = new Random();
          

            for (int i = 0; i <= 3; i++)
            {
                int value = rnd.Next(0, 4);
                int value2 = rnd.Next(0, 4);
                int value3 = rnd.Next(0, 4);
                Console.WriteLine($"{GetFullName(fName[value], lName[value2], pName[value3])}");
            }
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string FullName = ($"{lastName} {firstName}  {patronymic}");
            return FullName;
        }
    }
}
