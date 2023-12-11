// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


void Print()
{
    int[] numbers = new int[10]; 
    Random random = new Random(); 
    int сount = 0; 

    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(100, 1000); 
        Console.Write(numbers[i] + " "); 

        if (numbers[i] % 2 == 0)
        {
            сount++;
        }
    }
    Console.WriteLine($"\nКолличество четных чисел в массиве: {сount}");
}

Print();