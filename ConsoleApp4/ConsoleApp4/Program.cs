using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число :");
            string x = Console.ReadLine();
            int num ;
            bool isNum = int.TryParse(x, out num);
            if (isNum)
            {
                if (num % 2 == 0)
                    Console.WriteLine("Число четное");
                else
                    Console.WriteLine("Число не четное");
            }    
               
            else
                Console.WriteLine("Это не число!");
          
        }
    }
}
