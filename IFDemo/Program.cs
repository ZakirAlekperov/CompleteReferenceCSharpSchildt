//Продемонстрировать применение условного оератора if

using System;

class IfDemo
{
    static void Main(string[] args)
    {
        int a, b, c;

        a = 2;
        b = 3;

        if (a < b) Console.WriteLine("a меньше b");
        
        Console.WriteLine();

        c = a - b;

        Console.WriteLine("c содержит "+ c);

        if(c >= 0) Console.WriteLine("значение с неотрицательно");
        if (c < 0) Console.WriteLine("Значение с отрицательно");

        Console.WriteLine();

        c = b - a;

        Console.WriteLine("c содержит " + c);

        if (c >= 0) Console.WriteLine("Значение с неотрицательно");
        if (c < 0) Console.WriteLine("Значение с отрицательно");
    }
}