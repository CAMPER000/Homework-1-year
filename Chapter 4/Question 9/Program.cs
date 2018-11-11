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
            /*Напишете програма, която прочита едно цяло число n от конзолата.
            След това прочита още n на брой числа от конзолата и отпечатва
            тяхната сума.*/

            int sum = 0;

            Console.Write("Enter numbers count: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter {0} number: ", i + 1);
                sum += int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sum of all numbers is {0}.", sum);
        }
    }
}
