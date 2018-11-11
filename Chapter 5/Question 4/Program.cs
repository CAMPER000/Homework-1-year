using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сортирайте 3 реални числа в намаляващ ред. Използвайте вложени if оператори.

            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c && b>c)
            {
                Console.WriteLine("{0}>{1}>{2}", a, b, c);

            }
            else if (a<b && a<c && c < b)
            {
                Console.WriteLine("{0}>{1}>{2}", b, c, a);
            }
            else if (a>b && a>c && b<c)
            {
                Console.WriteLine("{0}>{1}>{2}", a, c, b);
            }
            else if (a < b && a > c && b > c)
            {
                Console.WriteLine("{0}>{1}>{2}", b, a, c);
            }
            else if (a < b && a < c && b < c)
            {
                Console.WriteLine("{0}>{1}>{2}", c, b, a);
            }
            else if (a > b && a < c && b < c)
            {
                Console.WriteLine("{0}>{1}>{2}", c, a, b);
            }
        }
    }
}
