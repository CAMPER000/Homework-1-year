using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която пресмята сумата (с точност до 0.001): 1+
            1/2 + 1/3 + 1/4 + 1/5 + ...*/
            Console.Write("Enter last number: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 1.0;

            for (int i = 2; i <= n; i++)
            {
                sum += (1.0 / i);
            }

            Console.WriteLine("{0:F3}", sum);
        }
    }
}
