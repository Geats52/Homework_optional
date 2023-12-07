//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

void OneAndTwo(int num)
{
    if(num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine($"{num} -> yes");
    }
    else
    {
        Console.WriteLine($"{num} -> no");
    }
}

int result = int.Parse(Console.ReadLine()!);
OneAndTwo(result);