using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._06._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Найдите сумму квадратов всех целых чисел от a до b(Значения a и b вводятся с клавиатуры)
            Console.WriteLine("Введите число a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = Convert.ToInt32(Console.ReadLine());
            int v = 0;
            for(int i=a; i<=b; i++)
            {
                v = v + i * i;
            }
            Console.WriteLine("Ответ" + v);
            Console.ReadKey();
        }
    }
}
