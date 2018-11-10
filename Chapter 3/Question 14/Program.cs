
// Напишете програма, която проверява дали дадено число n (1 < n < 100) е просто (т.е. се дели без остатък само на себе си и на единица).

using System;


namespace Zad._14
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n = int.Parse(Console.ReadLine());
            bool Prime = true;

            Prime = true;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Prime = false;
                    break;
                }
            }

            Console.WriteLine(" Числото е просто: {0}",Prime);

        }
    }
}
