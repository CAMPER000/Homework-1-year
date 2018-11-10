
// Напишете програма, която разменя битовете на позиции {p, p+1, …, p+k-1) с битовете на позиции {q, q+1, …, q+k-1} на дадено цяло положително число.

using System;


namespace Zad._16
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write(" Позиция за размяна: ");
            int startExchangePosition = int.Parse(Console.ReadLine());

            Console.Write(" Бит за размяна: ");
            int exchangeBits = int.Parse(Console.ReadLine());

            Console.Write(" Смяна с позиция: ");
            int exchangeFromPosition = int.Parse(Console.ReadLine());

            int firstSeqBits = 0;
            int secondSeqBits = 0;
             for (int i = 0; i < exchangeBits; i++)
              {
                if (0 != (n & (1 << (startExchangePosition + i))))
                {
                    firstSeqBits |= (1 << i);
                }

                n &= ~(1 << startExchangePosition + i);

                if (0 != (n & (1 << (exchangeFromPosition + i))))
                {
                    secondSeqBits |= (1 << i);
                }

                n &= ~(1 << exchangeFromPosition + i);
              }

            n |= secondSeqBits << startExchangePosition;
            n |= firstSeqBits << exchangeFromPosition;

             Console.WriteLine(" Разменените битове (p, p+1, …, p+k-1) с битовете на позиции (q, q+1, …, q+k-1) са: {0}",n);

        }
    }
}
