using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която преобразува дадено число от десетична в
            двоична бройна система.*/
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            Console.WriteLine("Result is {0}", binary);
        }
    }
}
