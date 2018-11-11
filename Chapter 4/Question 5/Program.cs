using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишете програма, която чете от конзолата две цели числа(int) и
             отпечатва колко числа има между тях, такива, че остатъкът им от де -
             ленето на 5 да е 0.Пример: в интервала(14, 25) има 3 такива числа:
             15, 20 и 25.*/

            int c = 0;

            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0) c++;
            }

            Console.WriteLine("{0} numbers found.", c);
        }
    }
}
