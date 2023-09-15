/* 
 * Эта прогрмамма демонстрирует отличия между типами ind и double
 */

using System;

class Example3
{
    static void Main(string[] args)
    {
        int ivar; //объявить целочисленную переменную
        double dvar; // объявить переменную с плавающей точкой

        ivar = 100;
        dvar = 100.0;

        Console.WriteLine("Исходное значение ivar: "+ ivar);
        Console.WriteLine("Исходное значение dvar: "+ dvar);

        Console.WriteLine();

        ivar = ivar / 3;
        dvar = dvar / 3;

        Console.WriteLine("Значение ivar после деления "+ ivar);
        Console.WriteLine("Значение dvar псоле деления "+ dvar);
    }
}