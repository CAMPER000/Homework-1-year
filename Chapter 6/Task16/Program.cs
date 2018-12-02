using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която преобразува дадено число от шестнайсе-тична в десетична бройна система.
            Console.Write("Enter decimal number: ");
            int n = int.Parse(Console.ReadLine());
            string toDecimal = Convert.ToString(Convert.ToInt32(n, 16), 10);
            Console.WriteLine("Result is {0}", toDecimal);
        }
    }
}
