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
            /*Напишете програма, която отпечатва три числа в три виртуални
            колони на конзолата. Всяка колона трябва да е с широчина 10 сим-
            вола, а числата трябва да са ляво подравнени. Първото число трябва
            да е цяло, в шестнадесетична бройна система, второто да е дробно
            положително, а третото да е дробно отрицателно. Последните две
            числа да се закръглят до втория знак след десетичната запетая.*/
            int nHex = 155;
        
            Console.WriteLine("|0x{0,-8:X}", nHex);
            double posNum = 1.2597;
            Console.WriteLine("|{0 , -10:f2}",posNum);

            double negNum = -1.9547;
            Console.WriteLine("|{0,-10:f2}", negNum);

        }
    }
}
