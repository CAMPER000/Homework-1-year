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
            /*Напишете програма, която чете от конзолата радиуса "r" на кръг и
            отпечатва неговото лице и обиколка.*/
            double r;
            double p = 3.14;
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("P= {0}", 2 * p * r);
            Console.WriteLine("S= {0}", p * r * r);


        }
    }
}
