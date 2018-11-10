
//  Напишете програма, която разменя стойностите на битовете на позиции 3, 4 и 5 с битовете на позиции 24, 25 и 26 на дадено цяло положително число.

using System;


namespace Zad._15
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n = int.Parse(Console.ReadLine());

            int startExchangePosition = 3;
            int exchangeBits = 3;
            int exchangeFromPosition = 24;

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

            Console.WriteLine(" Разменените битове 3, 4 и 5 с 24, 25 и 26 са: {0}",n);

        }
    }
}
