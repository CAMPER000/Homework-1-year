
// Напишете израз, който да проверява дали дадено цяло число е четно или нечетно.

using System;


namespace Zad._2
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int a = int.Parse(Console.ReadLine());
            bool divisible = a % 35 == 0 ? true : false;
            Console.WriteLine(" {0} се дели на 5 и на 7 ? - {1}", a, divisible);
        }
    }
}
