using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която чете от конзолата положително цяло
            число N (N < 20) и отпечатва матрица с числа като на фигурата по-
            долу:*/
            Console.Write("Enter N: (N < 20) ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine("");
            }
        }
    }
}
