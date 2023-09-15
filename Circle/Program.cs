//Вычисление площажи круга

using System;

class Circle
{
    static void Main(string[] args)
    {
        double radius;
        double area;

        radius = 10.0;

        area = radius * radius * 3.1416;

        Console.WriteLine("Площадь равна: " + area);
    }
}