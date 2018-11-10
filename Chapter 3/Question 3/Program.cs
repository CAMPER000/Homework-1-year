
// Напишете израз, който да проверява дали третата цифра (отдясно на ляво) на дадено цяло число е 7.

using System;


namespace Zad._3
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int a = int.Parse(Console.ReadLine());
            bool isSeven = (a / 100) % 10 == 7 ? true : false;
            Console.WriteLine(" Третата цифра от {0} е 7 ? - {1}", a, isSeven);
        }
    }
}
