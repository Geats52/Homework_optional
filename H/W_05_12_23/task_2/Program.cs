// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
int x = int.Parse(Console.ReadLine()!);
int y = int.Parse(Console.ReadLine()!);

x = 5;
y = 7;

if (x!==0)
{
    if (y!==0)
        Console.WriteLine(x, y; -x, -y);
    else
        Console.WriteLine("Ошибка координат");

}

else
    Console.WriteLine("Ошибка координат");

    //У меня не получилось Т_Т