// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

int N = int.Parse(Console.ReadLine()!);
float result =  (float) N/100;
Console.WriteLine(result);



// Альтернативный (правильный) вариант:
//string MaxNum(int num)
//{
//    Console.WriteLine(num);
//    string allNums = "";

//    while (num > 0)
//    {
//        allNums = num % 10 + "," + allNums;
//        num /= 10;

//    }
//    return allNums;
//}
//Console.WriteLine(MaxNum(new Random().Next(1, 100000)));
