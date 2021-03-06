﻿
//  Напишете програма, която приема за вход четирицифрено число във формат abcd  (например числото 2011) и след това извършва следните действия върху него:
// - Пресмята сбора от цифрите на числото (за нашия пример 2+0+1+1 = 4).
// - Разпечатва на конзолата цифрите в обратен ред: dcba (за нашия пример резултатът е 1102).
// - Поставя последната цифра, на първо място: dabc (за нашия пример резултатът е 1201).
// - Разменя мястото на втората и третата цифра: acbd (за нашия пример резултатът е 2101).

using System;


namespace Zad._10
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int abcd = int.Parse(Console.ReadLine());
            int a = abcd / 1000;
            int b = (abcd / 100) % 10;
            int c = (abcd / 10) % 10;
            int d = abcd % 10;

            Console.WriteLine(" 1. Сумата на числата е: {0}", a + b + c + d);
            Console.WriteLine(" 2. Чифрите в обратен ред са: {3}{2}{1}{0}", a, b, c, d);
            Console.WriteLine(" 3. Размяна с последна и първа чифра: {3}{0}{1}{2}", a, b, c, d);
            Console.WriteLine(" 4. Разманя на втора и трета цифра: {0}{2}{1}{3}", a, b, c, d);
        }
    }
}
