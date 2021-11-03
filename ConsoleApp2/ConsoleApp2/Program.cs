using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветсвует усреднитель температуры!))\n" + "Введите минимальную температуру за сутки:");
            string min = Console.ReadLine();
            int num;
            bool isNum = int.TryParse(min, out num);
            if (isNum)
                Console.WriteLine("Температура записана");
            else
            {
                Console.WriteLine("Введите температуру цифрами!");
                return;
            }
            Console.WriteLine("Введите максимальную температуру за сутки:");
            string max = Console.ReadLine();
            int num1;
            bool isNum1 = int.TryParse(max, out num1);
            if (isNum)
                Console.WriteLine("Температура записана");
            else
                Console.WriteLine("Введите температуру цифрами!");
            double med = (num + num1) / 2.0;

            Console.WriteLine($"Средняя температура за сутки:{med}");
        }
    }
}
