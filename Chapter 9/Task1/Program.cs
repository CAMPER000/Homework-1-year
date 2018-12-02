using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void ReturnName(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }


        static void Main(string[] args)
        {
            /*Напишете метод, който при подадено име отпечатва на конзолата
            "Hello, <name>!" (например "Hello, Peter!"). Напишете програма,
            която тества дали този метод работи правилно.*/
            Console.Write("Enter name: ");
            ReturnName(Console.ReadLine());
        }
    }
}
