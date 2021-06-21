using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введи число n");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = n / 100;
            int c = n % 10;
            int b = n % 100 / 100;
            if(a==b && b == c)
            {
               Console.WriteLine("Цифры одинаковые");
            }
            else
            {
               Console.WriteLine("Цифры не одинаковые");
            }
            Console.ReadKey();
        }
    }
}
