// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int a = new Random().Next(10, 100);
Console.WriteLine(a);
int b = new Random().Next(10, 100);
Console.WriteLine(b);

if( a > b)
	Console.WriteLine("Число 'a' большее");
else
	Console.WriteLine("Число 'b' большее");


// Альтернативный (правильный) вариант:

//int MaxNumber(int a)
//{
//	Console.WriteLine(a);
//
//	if(a % 10 > a / 10)
//	    return a % 10;
//	return a / 10;
//}
//Console.WriteLine(MaxNumber(new Random().Next(10, 100)));
