using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която чете от конзолата поредица от цели числа и
            отпечатва най-малкото и най-голямото от тях.*/
            int lowest = 0;
            int highest = 0;
            int input;
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                input = int.Parse(Console.ReadLine());
                if (i == 0) lowest = highest = input;
                else
                {
                    if (lowest > input) lowest = input;
                    if (highest < input) highest = input;
                }
            }
            Console.WriteLine("Lowest - {0}, Highest - {1}", lowest, highest);

        }
    }
}
