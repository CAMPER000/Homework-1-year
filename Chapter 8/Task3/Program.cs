using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void conversion(string value)
        {
            Console.WriteLine("{0} to decimal is {1}.",
                value, Convert.ToInt32(value, 16));
            Console.WriteLine("{0} to decimal is {1}.\n", value,
                Convert.ToString(Convert.ToInt32(value, 16), 2));
        }

       
        
       

        static void Main(string[] args)
        {
            /*Погледнете упътването за предходната задача. Резултати:
            FA(16) = 250(10) = 11111010(2), 2A3E(16) = 10814(10) =
            10101000111110(2), FFFF(16) = 65535(10) = 1111111111111111(2), 5A0E9(16) =
            368873(10) = 1011010000011101001(2).*/

            conversion("2A3E");
            conversion("FA");
            conversion("FFFF");
            conversion("5A0E9");
        }
    }
}
