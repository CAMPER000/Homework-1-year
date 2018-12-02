using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която отпечатва на конзолата числата от 1 до N,
            които не се делят едновременно на 3 и 7. Числото N да се чете от
            стандартния вход.*/
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % (3 * 7) == 0)
                {
                    Console.WriteLine("");

                }
                else
                {
                    Console.WriteLine(i);
                }
               
                
            }
        }
    }
}
