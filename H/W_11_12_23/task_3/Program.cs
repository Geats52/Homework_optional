// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

void Main()
{
    int[] numbers = {1, 5, 7, 6, 4, 9};
    int temp;
    Console.Write("Исходный массив: ");
    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }
    for (int i = 0; i < numbers.Length / 2; i++)
    {
        temp = numbers[i];
        numbers[i] = numbers[numbers.Length - 1 - i];
        numbers[numbers.Length - 1 - i] = temp;
    }
    
    Console.Write("\nПеревернутый массив: ");
    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }
}

Main();