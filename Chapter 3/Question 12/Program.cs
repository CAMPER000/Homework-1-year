
// Напишете булев израз, който проверява дали битът на позиция p на цялото число v има стойност 1. Пример v=5, p=1 -> false.

using System;

namespace Zad._12
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write(" Въведете позиция: ");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine(" Стойност 1 на бита: {0}",0 != (n & (1 << p)));
        }
    }
}
