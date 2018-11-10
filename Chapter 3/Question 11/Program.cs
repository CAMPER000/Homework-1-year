
// Дадено е число n и позиция p. Напишете поредица от операции, които да отпечатат стойността на бита на позиция p от числото n (0 или 1). Пример: n=35, p=5 -> 1. Още един пример: n=35, p=6 -> 0.

using System;


namespace Zad._11
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write(" Въведете позиция: ");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine(" Cтойността на бита e: {0}",0 == (n & (1 << p)) ? 0 : 1);

        }
    }
}
