
// Напишете програма, която проверява дали дадена точка О (x, y) е вътре в окръжността К ((0,0), 5). Пояснение: точката (0,0) е център на окръжността, а радиусът й е 5.

using System;


namespace Zad._8
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

              if ((x * x) + (y * y) > (r * r))
              {
                Console.WriteLine(" Toчката е вън от окръжноста К({0},{1})",x,y);
              }
              else
              {
                Console.WriteLine(" Toчката е в окръжноста К({0},{1})", x, y);
              }

        }
    }
}
