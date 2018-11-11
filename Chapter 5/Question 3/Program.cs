using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която намира най-голямото по стойност число,
            измежду три дадени числа.*/
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a>b&&a>c)
            {
                Console.WriteLine("A is biggest");
               
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("B is biggest");

            }
            else
            {
                Console.WriteLine("C is biggest");
            }
        }
    }
}
