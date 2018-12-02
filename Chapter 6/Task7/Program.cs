using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която пресмята N!*K!/(N-K)! за дадени N и K
            (1<K<N).*/
            Console.Write("Enter N: (1<K<N) ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: (1<K<N) ");
            int k = int.Parse(Console.ReadLine());

            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }

            for (int i = k - 1; i > 0; i--)
            {
                k *= i;
            }

            n= n*k/ (n - k);
            Console.WriteLine("Result is {0}", n);
        }
    }
}
