using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която чете две числа от конзолата и отпечатва
            по-голямото от тях. Решете задачата без да използвате условни
            конструкции.*/
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} > {1}", Math.Max(a, b), Math.Min(a, b));

        }
    }
}
