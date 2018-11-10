
// Напишете програма, която за подадени от потребителя дължина и височина на право­ъгълник, пресмята и отпечатва на конзолата неговия периметър и лице.

using System;

namespace Zad._6
{
    
class Program
    {
        static void Main()
        {
            Console.Write(" А = ");
            double a = double.Parse(Console.ReadLine());

            Console.Write(" B = ");
            double b = double.Parse(Console.ReadLine());

            double per = 2 * (a + b);
            Console.WriteLine(" Периметъра е {0} см.", per);

            double lice = a * b;
            Console.WriteLine(" Лицето е {0} см.", lice);
        }
    }
}
