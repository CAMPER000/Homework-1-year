
// Напишете програма, която проверява дали дадена точка О (x, y) е вътре в окръжността К ((0,0), 5) и едновременно с това извън право­ъгълника ((-1, 1), (5, 5). Пояснение: правоъгълникът е зададен чрез координатите на горния си ляв и долния си десен ъгъл.

using System;


namespace Zad._9
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Х = ");
            int x = int.Parse(Console.ReadLine());

            Console.Write(" У = ");
            int y = int.Parse(Console.ReadLine());

            int r = 5;

            bool isInCircle = (x * x + y * y) < r * r;
            bool isInRectangle = x > -1 && x < 5 && y > 1 && y < 5;

            Console.WriteLine(" Точката е вътрешна - {0}", isInCircle && !isInRectangle);


        }
    }
}
