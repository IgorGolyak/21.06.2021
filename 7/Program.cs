using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            for (int i = 3; i <= 24; i = i + 3)
            {
                Console.WriteLine("через" + i + "часа, столько Серёг" + n);
                n = n * 2;

            }

            Console.ReadKey();
        }
    }
}
