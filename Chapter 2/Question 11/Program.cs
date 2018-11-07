using System;

namespace Zad._11
{
    class Program
    {
        static void Main()
        {
            char COPYRIGHT = '\u00a9';
            Console.WriteLine(new String(' ', 5) + COPYRIGHT);
            Console.WriteLine(new String(' ', 4) + COPYRIGHT + new String(' ', 1) + COPYRIGHT);
            Console.WriteLine(new String(' ', 3) + COPYRIGHT + new String(' ', 3) + COPYRIGHT);
            Console.WriteLine(new String(' ', 2) + COPYRIGHT + new String(' ', 5) + COPYRIGHT);
            Console.WriteLine(new String(' ', 1) + COPYRIGHT + new String(' ', 7) + COPYRIGHT);
            Console.WriteLine(" " + new String(COPYRIGHT, 9));

        }
    }
}
