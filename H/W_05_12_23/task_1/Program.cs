//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

using System.ComponentModel;

int n = int.Parse(Console.ReadLine()!);

if (n % 7 == 0)
{
    if (n % 23 == 0)
        Console.WriteLine("Найденно число!");
    else
        Console.WriteLine("Число не найденно");

}

else
    Console.WriteLine("Число не найденно");