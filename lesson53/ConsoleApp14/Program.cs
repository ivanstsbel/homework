using System;
using System.IO;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа от 0 до 255");
            string numbStr = Console.ReadLine();
            string[] numbStrArr = numbStr.Split();
            byte[] numbArr = new byte[numbStrArr.Length];
            for (int i = 0; i < numbStrArr.Length; i++)
            {
                Convert.ToByte(numbStrArr[i]);
                numbArr[i] = Convert.ToByte(numbStrArr[i]);

            }
            
            File.WriteAllBytes("bytes.bin", numbArr);
        }
    }
}
