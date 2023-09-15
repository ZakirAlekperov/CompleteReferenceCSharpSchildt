using System;

class Example2
{
    static void Main(string[] args)
    {
        int x; // здесь обьявляется перменная 
        int y; // здесь обьявляется еще одна переменная

        x = 100; // здесь переменной x присваивается значение 100

        Console.WriteLine("x содержит " + x);

        y = x / 2;

        Console.Write("y содержит x / 2: ");

        Console.WriteLine(y);
    }
}