// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

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


int[] EvenNum(int size)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count += 1;
    }
    return count;
}

int num = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);
int result = EvenNum(mass);
Console.WriteLine(EvenNum(mass));

















// void Print()
// {
//     int[] numbers = new int[10]; 
//     Random random = new Random(); 
//     int сount = 0; 

//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = random.Next(100, 1000); 
//         Console.Write(numbers[i] + " "); 

//         if (numbers[i] % 2 == 0)
//         {
//             сount++;
//         }
//     }
//     Console.WriteLine($"\nКолличество четных чисел в массиве: {сount}");
// }

// Print();