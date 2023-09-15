//Продемонстрировать применение оператора цикла for.

using System;

class ForDemo
{
    static void Main(string[] args)
    {
        int count;

        for(count =0; count <5; count++)
        {
            Console.WriteLine(count);
        }
        Console.WriteLine("Готово");
    }
}