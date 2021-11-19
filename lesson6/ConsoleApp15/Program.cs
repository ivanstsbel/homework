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
            update();

            while (exit)
            {

                Console.WriteLine($"Введите 2 для обновления списка процессов, 1 для завершения процесса, 0 для выхода из программы ");
                string num = Console.ReadLine();
                int numint = 0;
                if (!int.TryParse(num, out numint) || numint > 2)
                {
                    Console.WriteLine("Не коректный ввод!");
                    continue;
                }
                if (numint == 2)
                    update();
                if (numint == 1)
                {
                    Console.WriteLine("Введите 0 для завершения процесса по Id , 1 для завершения процесса по имени: ");

                    string n = Console.ReadLine();
                    int m = 0;
                    if (!int.TryParse(n, out m) || m > 1)
                    {
                        Console.WriteLine("Не корректный ввод!");
                        continue;
                    }
                    if (m == 0)
                    {
                        Console.WriteLine("Введите Id процесса: ");
                        string j = Console.ReadLine();
                        int p = 0;
                        if (!int.TryParse(j, out p))
                        {
                            Console.WriteLine("Не коректный ввод!");
                            continue;
                        }
                         else   taskkillid(p);

                    }
                    if (m == 1)
                    {
                        Console.WriteLine("Введите имя процесса (С учетом регистра!) : ");
                        string j = Console.ReadLine();
                        taskkillname(j);
                    }



                }
                if (numint == 0)
                    exit = false;

            }
        }
        static void update()
        {
            for (int i = 0; i < processes.Length; i++)
            {
                Console.WriteLine($"{processes[i].ProcessName}               \t ID: {processes[i].Id}");

            }
            Console.WriteLine($"Всего процессов: {processes.Length + 1} ");
        }
        static void taskkillid(int id)
        {
            bool kill = false;
            for (int i = 0; i < processes.Length; i++)
            {
                if (id == processes[i].Id)
                {
                    processes[i].Kill();
                    kill = true;
                    Console.WriteLine($" Процесс с ID {id} завершен!");

                }
                if (i == processes.Length - 1 && kill == false)
                {
                    Console.WriteLine("Процесс не найден!");

                }

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
                {
                    Console.WriteLine("Процесс не найден!");

                }

            }
            kill = false;

        }
    }
}
