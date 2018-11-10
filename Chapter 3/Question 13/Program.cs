
// Дадено е число n, стойност v (v = 0 или 1) и позиция p. Напишете поредица от операции, които да променят стойността на n, така че битът на позиция p да има стойност v. Пример n=35, p=5, v=0 -> n=3. Още един пример: n=35, p=2, v=1 -> n=39.

using System;


namespace Zad._13
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write(" Въведете позиция: ");
            int p = int.Parse(Console.ReadLine());

            Console.Write(" Въведете стойност: ");
            int v = int.Parse(Console.ReadLine());

             if (0 == v)
              {
                v = ~(1 << p);
                v = v & n;
              }
             else
              {
                v = 1 << p;
                v = v | n;
              }

            Console.WriteLine(" N = {0}",v);

        }
    }
}
