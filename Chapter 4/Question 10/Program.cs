using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която прочита цяло число n от конзолата и отпе-
            //чатва на конзолата всички числа в интервала[1…n], всяко на
            //отделен ред.

            int sum = 0;
            Console.WriteLine("Enter number here:");
            int j = int.Parse(Console.ReadLine());
            
            for(int i=1; i<=j; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
