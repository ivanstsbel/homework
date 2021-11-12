using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите порядковый номер месяца :");
            string pn = Console.ReadLine();
            int number;
            bool tr = int.TryParse(pn, out number);
            if (!(tr == true && number < 13 && number > 0))
                Console.WriteLine("Ошибка: введите число от 1 до 12!");
            else Console.WriteLine($"{timeyear(vge(number))}") ;
            
        }
        static string vge(int n)
        {
            string vrr = null;
            switch(n)
                {
                case 1:
                    vrr = "winter";
                  break;
                case 2:
                    vrr = "winter";
                    break;
                case 3:
                    vrr = "Spring";
                    break;
                case 4:
                    vrr = "Spring";
                    break;
                case 5:
                    vrr = "Spring";
                    break;
                case 6:
                    vrr = "Summer";
                    break;
                case 7:
                    vrr = "Summer";
                    break;
                case 8:
                    vrr = "Summeк";
                    break;
                case 9:
                    vrr = "Autumn";
                    break;
                case   10:
                    vrr = "Autumn";
                    break;
                case 11:
                    vrr = "Autumn";
                    break;
                case 12:
                    vrr = "winter";
                    break;

            }
            return vrr;
      
        } 
        static string timeyear (string x)
        {
            if( x == "winter")
                return "Зима";
            if (x == "Spring")
                return "весна";
            if (x == "Summer")
                return "лето";
            if (x == "Autumn")
                return "осень";
            else return null;
        }

    }

    }

    
        

