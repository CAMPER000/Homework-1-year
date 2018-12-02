using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която преобразува дадено число от десетична в
            шестнайсетична бройна система.*/

            Console.Write("Enter decimal number: ");
            int n = int.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 10), 16);
            Console.WriteLine("Result is {0}", toDecimal);
        }
    }
}
