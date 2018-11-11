using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която отпечатва на конзолата първите 100 числа
            от редицата на Фибоначи: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144,
            233, 377, ...*/

            int f1 = 0;
            int f2 = 1;
            int sum = 1;
            int count = 0;
            Console.WriteLine(f1);
            while (count < 100)
            {
                sum = f1 + f2;
                f1 = f2;
                f2 = sum;
                Console.WriteLine(f2);
                count++;
            }
        }
    }
}
    
