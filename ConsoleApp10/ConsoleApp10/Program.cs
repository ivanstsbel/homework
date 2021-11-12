using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел :");
            string str = Console.ReadLine();
            bool trye = true;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (Char.IsNumber(c) || c == ' ')
                    continue;
                else
                {
                    Console.WriteLine("Ошибка! Строка должна состоять из чесел и пробелов!");
                    trye = false;
                    break;
                }
            }

            if (trye == true)
            {
                var nums = str.Split();
                int sum = 0;
                for (int i = 0; i < nums.Length; sum += int.Parse(nums[i++])) ;
                Console.WriteLine(sum);
            }
        }
    }
}
