using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите сторону a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сторону c");
            double c = Convert.ToDouble(Console.ReadLine());
            if(a==b && b == c)
            {
                Console.WriteLine("Является");
            }
            else
            {
                Console.WriteLine("Не является");
            }
            Console.ReadKey();
        }
    }
}
