
// Силата на гравитационното поле на Луната е приблизително 17% от това на Земята. Напишете програма, която да изчислява тежестта на човек на Луната, по дадената тежест на Земята.

using System;

namespace Zad._7
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете тежеста си ");
            double ЕWeigth = double.Parse(Console.ReadLine());
            double МWeigth = 0.17 * ЕWeigth;
            Console.WriteLine(" На Луната ще тежите {0}",МWeigth);

        }
    }
}
