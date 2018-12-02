﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*В комбинаториката числата на Каталан (Catalan’s numbers) се изчис-
            ляват по следната формула: , за n ≥ 0. Напи-
            шете програма, която изчислява n-тото число на Каталан за дадено n.*/

            Console.Write("Enter N: (N >=0 ) ");
            int n = int.Parse(Console.ReadLine());

            int fact2N = 2 * n, factNplus1 = n + 1;

            for (int i = fact2N - 1; i > 0; i--) fact2N *= i;
            for (int i = factNplus1 - 1; i > 0; i--) factNplus1 *= i;
            for (int i = n - 1; i > 0; i--) n *= i;

            Console.WriteLine("Result is {0}", fact2N / (factNplus1 * n));
        }
    }
}