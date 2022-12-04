//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным
using System;
{
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num%2 == 0)
    {
        Console.WriteLine("Число четное.");
    }
    else 
    {
        Console.WriteLine("Число нечетное.");
    }

    Console.ReadKey();
}