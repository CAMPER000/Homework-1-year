using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Правилото е "делим на 2 и долепяме остатъците в обратен ред".
            За делене с остатък използваме оператора %. Можете да се изхитрите,
            като използвате Convert.ToString(numDecimal, 2).*/
            Console.Write("Enter decimal number: ");
            int deci = Int32.Parse(Console.ReadLine());     
            
            Console.WriteLine("{0} to binary is {1}.", deci, deci.ToString(deci, 2));

        }
    }
}
