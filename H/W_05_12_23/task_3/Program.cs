// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int a = new Random().Next(10,99);
Console.WriteLine(a);
int b = new Random().Next(10,99);
Console.WriteLine(b);

if(a>b)
	Console.WriteLine("Число 'a' большее");
else
	Console.WriteLine("Число 'b' большее");



