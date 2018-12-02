using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която за дадени две числа, намира най-големия
                им общ делител (НОД) и най-малкото им общо кратно (НОК).
                Можете да използвате формулата НОК(a, b) = |a*b| / НОД(а, b).*/
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            while (a != 0 && b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }

            if (a == 0) Console.WriteLine(b);
            else Console.WriteLine(a);
        }
    }
}
