using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която чете от конзолата числото N и отпечатва
            сумата на първите N члена от редицата на Фибоначи: 0, 1, 1, 2, 3, 5,
            8, 13, 21, 34, 55, 89, 144, 233, 377, ...*/
            int n;
            n = int.Parse(Console.ReadLine());
            int a, b, s;
            a = 0;
            b = 1;
            s = 0;
            Console.WriteLine(a);
            Console.WriteLine(b);

            
            for (int i=2; i<=n; i++)
            {
                s = a + b;
                Console.WriteLine(s);
                a = b;
                b = s;
                
            }
        }
    }
}
