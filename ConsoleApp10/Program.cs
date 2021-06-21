using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число x");
            int x = Convert.ToInt32(Console.ReadLine());
            int a = x / 100;
            int b = x % 10;
            if (a == b)
            {
                Console.WriteLine("является");
            }
            else
            {
                Console.WriteLine(" не является");
            }
            Console.ReadKey();
        }
    }
}
