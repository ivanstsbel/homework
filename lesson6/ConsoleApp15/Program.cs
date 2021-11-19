using System;
using System.Diagnostics;

namespace ConsoleApp15
{
    class Program
    {
        static Process[] processes = Process.GetProcesses();
        static void Main(string[] args)
        {
            bool exit = true;
            for (int i = 0; i < processes.Length; i++)
            {
                
                Console.WriteLine($"{processes[i].ProcessName}               \t ID: {processes[i].Id}");
            }
            while (exit)
            {
                Console.WriteLine($"Всего процессов: {processes.Length +1} \n Введите 1 для завершения процесса, 0 для выхода из программы ");
                string num = Console.ReadLine();
                int numint = 0;
                if (!int.TryParse(num, out numint))
                    continue;
                else Console.WriteLine("Не коректный ввод!");
                if (numint == 1)
                {
                    Console.WriteLine("Введите 1 для завершения процесса по Id , 2 для завершения процесса по имени: ");
                   
                    string n = Console.ReadLine();
                    int m = 0;
                    int.TryParse(n, out m);
                    if (m == 1)
                    {
                        Console.WriteLine("Введите Id процесса: ");
                        string j = Console.ReadLine();
                        int l = 0;
                        if (int.TryParse(j, out l))
                            taskkillid(l);
                        else Console.WriteLine("Не коректный ввод!");
                    }
                    if (m ==2)
                    {
                        Console.WriteLine("Введите имя процесса (С учетом регистра!) : ");
                        string j = Console.ReadLine();
                        taskkillname(j);
                    }


                   
                }
                if (numint == 0)
                    exit = false;
                else
                {
                    Console.WriteLine("Некоректный ввод!");
                        continue;
                        }
            }
        }
        static void taskkillid(int id)
        {
            bool kill = false;
            for(int i =0;i< processes.Length;i++)
            {
                if (id == processes[i].Id) 
                {
                    processes[i].Kill();
                    kill = true;
                    Console.WriteLine($" Процесс с ID {id} завершен!");
                }
                if(i== processes.Length-1&&kill==false) 
                    Console.WriteLine("Процесс не найден!");
                
            }
            kill = false;

        }
        static void taskkillname(string name)
        {
            bool kill = false;
            for (int i = 0; i < processes.Length; i++)
            {
                if (name == processes[i].ProcessName)
                {
                    processes[i].Kill();
                    kill = true;
                    Console.WriteLine($" Процесс с именем {name} завершен!");
                }
                if (i == processes.Length - 1 && kill == false)
                    Console.WriteLine("Процесс не найден!");

            }
            kill = false;

        }
    }
}
