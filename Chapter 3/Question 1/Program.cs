
// Напишете израз, който да проверява дали дадено цяло число е четно или нечетно.

using System;


namespace Zad._1
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int a = int.Parse(Console.ReadLine());
            bool even = a % 2 == 0 ? true : false;
            Console.WriteLine(" {0} е четно ? - {1}", a, even);
        }
    }
}
