
//  Напишете израз, който изчислява площта на трапец по дадени a, b и h

using System;


namespace Zad._5
{
    class Program
    {
        static void Main()
        {
            Console.Write(" А = ");
            double a = double.Parse(Console.ReadLine());
            
            Console.Write(" B = ");
            double b = double.Parse(Console.ReadLine()); 
            
            Console.Write(" H = ");
            double h = double.Parse(Console.ReadLine());
           
            double pl = (a + b) * h / 2;
            Console.WriteLine(" Площа е {0} см.",pl);
        }
    }
}
