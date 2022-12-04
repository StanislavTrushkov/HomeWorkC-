//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
using System;
{
    Console.WriteLine("Введите число: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine($"Все четные числа в диапазоне от 1 до {num}:");
    for (int i = 1; i <= num; i++)
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    Console.ReadKey();
}