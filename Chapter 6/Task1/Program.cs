using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която отпечатва на конзолата числата от 1 до N.
            Числото N трябва да се чете от стандартния вход.*/

            int n;
            n = int.Parse(Console.ReadLine());
            for (int i=1; i<=n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
