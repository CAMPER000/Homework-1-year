using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която преобразува дадено число от двоична в
            десетична бройна система.*/
            Console.Write("Enter binary number: ");
            int n = int.Parse(Console.ReadLine());
            string toDouble = Convert.ToString(Convert.ToInt32(n , 2), 10);
            Console.WriteLine("Result is {0}", toDouble);
        }
    }
}
