using System;


namespace Zad._3
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете плаваща стойност за числото А = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write(" Въведете плаваща стойност за числото B = ");
            double b = double.Parse(Console.ReadLine());

            double c = a+b;
            Console.WriteLine( "A + B = {0:f6}", c);

        }
    }
}
