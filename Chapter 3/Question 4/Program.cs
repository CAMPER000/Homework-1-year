
// Напишете израз, който да проверява дали третия бит на дадено число е 1 или 0.

using System;


namespace Zad._4
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int a = int.Parse(Console.ReadLine());
            int Bit = (a >> 3) & 1;
            Console.WriteLine(" Третия Бит на числото е {0}",Bit);

        }
    }
}
