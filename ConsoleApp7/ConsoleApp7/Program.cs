using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] pb = new string[5, 2];
            pb[0, 0] = "Геннайдий Петрович";
            pb[1, 0] = "Алексей Павлович";
            pb[2, 0] = "Владислав Александрович";
            pb[3, 0] = "Андрей Олегович";
            pb[4, 0] = "Александр анатольевич";
            pb[0, 1] = "+79181231234";
            pb[1, 1] = "+79181234567";
            pb[2, 1] = "+79185734516";
            pb[3, 1] = "+79184321589";
            pb[4, 1] = "+79180932468";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Контакт № {i+1}: {pb[i,0]} {pb[i,1]}");
            }
            
        }
    }
}
