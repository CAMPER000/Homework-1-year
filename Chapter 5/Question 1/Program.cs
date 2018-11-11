using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Да се напише if конструкция, която проверява стойността на две цело-
            числени променливи и разменя техните стойности, ако стойността на
            първата променлива е по-голяма от втората.*/

            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int c = a;
            Console.WriteLine("A : {0}  ||  B : {1}", a, b);

 2            if (a > b)
            {
                a = b;
                b = c;
                Console.WriteLine("A now = {0}  ||  B now = {1}", a, b);

            }
            else {
                Console.WriteLine("No change");
            }
        }
    }
}
