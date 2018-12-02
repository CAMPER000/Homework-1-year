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
            /*Използвайте методите за превръщане от една бройна система в
            друга. Можете да сверите резултатите си с калкулатора на Windows,
            който поддържа работа с бройни системи след превключване в режим
            "Programmer". Резултатите са 10010111, 100011, 11111011, 1111111111 и
            10000000000.*/

            Console.WriteLine("123 to binary {0}.", Convert.ToString(123, 2));
            Console.WriteLine("41 to binary {0}.", Convert.ToString(41, 2));
            Console.WriteLine("43 to binary {0}.", Convert.ToString(43, 2));
            Console.WriteLine("322 to binary {0}.", Convert.ToString(2, 2));
        }
    }
}
