// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

void Print()
{
    int size = arr.Length; 

    for (int i = 0; i < size; i++)
        Console.WriteLine($"{arr[i]} ");

    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(100, 1000);

    return arr;
}

int[] RevMass(int [] arr_1)
{
    int size = arr_1.Length;

    for (int i = 0; i < size / 2; i++)
        (arr_1[i], arr_1[size - i - 1]) = (arr_1[size - i - 1], arr_1[i]);
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
RevMass(mass);
Print(mass);



// void Main()
// {
//     int[] numbers = {1, 5, 7, 6, 4, 9};
//     int temp;
//     Console.Write("Исходный массив: ");
//     foreach (int number in numbers)
//     {
//         Console.Write(number + " ");
//     }
//     for (int i = 0; i < numbers.Length / 2; i++)
//     {
//         temp = numbers[i];
//         numbers[i] = numbers[numbers.Length - 1 - i];
//         numbers[numbers.Length - 1 - i] = temp;
//     }
    
//     Console.Write("\nПеревернутый массив: ");
//     foreach (int number in numbers)
//     {
//         Console.Write(number + " ");
//     }
// }

// Main();