using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Погледнете упътването за предходната задача. Резултат: F59E(16) и
            62878(10).*/
            Console.WriteLine("1111010110011110 to decimal is {0}.",
        Convert.ToInt64("1111010110011110", 2));

            Console.WriteLine("1111010110011110 to hexadecimal is {0}.",
                Convert.ToInt64("1111010110011110", 2).ToString("X"));
        }
    }
}
