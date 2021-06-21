using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("День");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine("Понидельник");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Вторник");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Среда");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Четверг");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Пятница");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Суббота");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Воскресенье");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка");
                        break;
                    }
                    Console.ReadKey();
            }
        }
    }
}
