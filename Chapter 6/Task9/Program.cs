using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която за дадени цели числа n и x, пресмята сумата: .
            int sum = 1, temp = 1;
            Console.Write("Enter n: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            int x = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                temp *= i / x;
                sum += temp;
            }

            Console.WriteLine("Result is {0}", sum);
        }
    }
}
